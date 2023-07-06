using apilfs.DTO;
using apilfs.Models;
using apilfs.Repository.Interfaces;
using apilfs.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;

namespace apilfs.Services.User
{
    public class UserService : IUserService
    {
        private readonly IUser _user;
        private readonly IRole _role;
        private readonly IRolesByUser _rolesByUser;
        private readonly IPermissionByRole _permissionByRole;
        private readonly IPermission _permission;
        private readonly ICustomers _customers;
        private readonly ICustomerOffice _customerOffice;
        private readonly ICustomerContact _customerContact;
        private readonly ISalesAgent _salesAgent;
        private readonly IOffice _office;
        private readonly ITier _tier;
        private readonly ISalesKam _salesKam;

        public UserService(IUser user, IRole role, IRolesByUser rolesByUser, IPermissionByRole permissionByRole, IPermission permission, 
            ICustomers customers, ICustomerOffice customerOffice, ICustomerContact customerContact, ISalesAgent salesAgent, IOffice office, 
            ITier tier, ISalesKam salesKam, IConfiguration configuration)
        {
            _user = user;
            _role = role;
            _rolesByUser = rolesByUser;
            _permissionByRole = permissionByRole;
            _permission = permission;
            _customers = customers;
            _customerOffice = customerOffice;
            _customerContact = customerContact;
            _salesAgent = salesAgent;
            _office = office;
            _tier = tier;
            _salesKam = salesKam;
            Configuration = configuration;
        }

        public UserRolesPermissions GetUserWithRoles(string email)
        {
            Models.User user = GetUserByEmail(email);
            if(user == null)
            {
                return null;
            }

            //Validar si está activo
            if(user.Active == false)
            {
                return null;
            }
            UserRolesPermissions userRolesPermissions = new UserRolesPermissions();
            userRolesPermissions.Id = user.Id;
            userRolesPermissions.User = user.User1;
            userRolesPermissions.FirstName = user.FirstName;
            userRolesPermissions.LastName = user.LastName;
            userRolesPermissions.Active = user.Active;

            List<Models.RolesByUser> rolesByUser = GetRolesByUser(user.Id).ToList();
            List<string> roles = new List<string>();
            List<string> permissions = new List<string>();
            rolesByUser.ForEach(item =>
            {
                //Obtener los roles del usuario
                Models.Role role = GetRoleById(item.IdRole);
                roles.Add(role.Name);

                //Obtener los permisos del usuario
                List<Models.PermissionsByRole> permissionsByRole = GetPermissionsByRole(item.IdRole).ToList();
                permissionsByRole.ForEach(itemPer =>
                {
                    Models.Permission permission = GetPermissionById(itemPer.IdPermission);

                    if (!permissions.Exists(it => it == permission.Name))
                    {
                        permissions.Add(permission.Name);
                    }

                });

            });
            userRolesPermissions.roles = roles;
            userRolesPermissions.permissions = permissions;

            string CUSTOMER = Configuration.GetSection("Roles").GetSection("Customer").Value;
            string SALES_REP = Configuration.GetSection("Roles").GetSection("SalesRep").Value;

            userRolesPermissions.roles.ForEach(rol =>
            {
                //Si es cliente, enviar info del customer: Customer, 
                if (rol == CUSTOMER) 
                {
                    //Buscar el customer por email de usuario
                    Customer customer = _customers.GetCustomerByEmail(userRolesPermissions.User);
                    if (customer == null)
                    {
                        throw new Exception("Error obtaining customer information");
                    }

                    var _custo = new apilfs.DTO.MapeoCustomers();
                    CustomersDto customerDto = _custo.MapearCustomer(customer);
                    userRolesPermissions.customerDto = customerDto;

                    userRolesPermissions.customerDto.CustomerOffices = GetCustomerOffice(customerDto.Id);
                    userRolesPermissions.customerDto.CustomerContacts = GetCustomerContact(customerDto.Id);

                }

                //Si es agente de ventas, enviar los clientes a los que atiende
                if (rol == SALES_REP)
                {
                    //Buscar el sales res por email
                    SalesRep salesRep = _salesAgent.GetSalesRepByEmail(email);
                    if (salesRep == null)
                    {
                        throw new Exception("Error getting information from sales agent");
                    }

                    var _sales = new apilfs.DTO.MapeoSalesRep();
                    SalesRepDto salesRepDto = _sales.MapearSalesRep(salesRep);
                    userRolesPermissions.salesRepDto = salesRepDto;

                    userRolesPermissions.salesRepDto.customersBySalesRepDto = GetCustomersBySalesAgent(salesRepDto.Id);
                }
            });
            return userRolesPermissions;
        }

        private List<CustomerOfficeDto> GetCustomerOffice(int IdCustomer)
        {
            List<CustomerOffice> customersOffice = _customerOffice.GetCustomerOfficeByCustomerId(IdCustomer).ToList();
            List<CustomerOfficeDto> customersOfficeDto = new List<CustomerOfficeDto>();
            customersOffice.ForEach(cusOf =>
            {
                var _custoOffice = new apilfs.DTO.MapeoCustomerOffice();
                CustomerOfficeDto customerOffice = _custoOffice.MapearCustomerOffice(cusOf);
                customersOfficeDto.Add(customerOffice);
            });
            return customersOfficeDto;
        }

        private List<CustomerContactDto> GetCustomerContact(int IdCustomer)
        {
            List<CustomerContact> customersContact = _customerContact.GetCustomerContactByCustomerId(IdCustomer).ToList();
            List<CustomerContactDto> customersContactDto = new List<CustomerContactDto>();
            customersContact.ForEach(cusCo =>
            {
                var _custoContact = new apilfs.DTO.MapeoCustomerContact();
                CustomerContactDto customerContact = _custoContact.MapearCustomerContact(cusCo);
                customersContactDto.Add(customerContact);
            });

            return customersContactDto;
        }

        private List<CustomersDto> GetCustomersBySalesAgent(int IdSalesAgent)
        {
            List<Customer> customers = _customers.GetCustomerByIdSalesRep(IdSalesAgent).ToList();
            List<CustomersDto> customersDto = new List<CustomersDto>();
            customers.ForEach(cust =>
            {
                var _custo = new apilfs.DTO.MapeoCustomers();
                CustomersDto customerDto = _custo.MapearCustomer(cust);
                customerDto.CustomerOffices = GetCustomerOffice(cust.Id);
                customerDto.CustomerContacts = GetCustomerContact(cust.Id);
                customersDto.Add(customerDto);
            });

            return customersDto;
        }

        private Models.User GetUserByEmail(string email)
        {
            if (email == null)
            {
                throw new Exception("E-mail was not received correctly");
            }
            return _user.GetUserByEmail(email);
        }

        private IQueryable<Models.RolesByUser> GetRolesByUser(int idUser)
        {
            return _rolesByUser.GetRolesByUser(idUser);
        }

        private Models.Role GetRoleById(int id)
        {
            return _role.GetRoleById(id);
        }

        private IQueryable<Models.PermissionsByRole> GetPermissionsByRole(int idRole)
        {
            return _permissionByRole.GetPermissionsByRole(idRole);
        }

        private Models.Permission GetPermissionById(int id)
        {
            return _permission.GetPermissionById(id);
        }

        public Models.User CreateUserWithRolesAndCustomerAndAgent(UserRolesCustomerAgentDto userRolesCustomerAgent)
        {
            //Validar que el email usuario exista
            if (String.IsNullOrEmpty(userRolesCustomerAgent.User))
            {
                throw new Exception("Email is required");
            }

            Models.User user = GetUserByEmail(userRolesCustomerAgent.User);
            if (user != null)
            {
                throw new Exception("User already exists");
            }

            if (String.IsNullOrEmpty(userRolesCustomerAgent.Role))
            {
                throw new Exception("The role is required");
            }

            Models.User userCreated = null;
            string CUSTOMER = Configuration.GetSection("Roles").GetSection("Customer").Value;
            string SALES_REP = Configuration.GetSection("Roles").GetSection("SalesRep").Value;

            if (userRolesCustomerAgent.Role == CUSTOMER)
            {
                if (userRolesCustomerAgent.Customer == null || String.IsNullOrEmpty(userRolesCustomerAgent.Customer.Code))
                {
                    throw new Exception("The Customer Code is required");
                }

                bool customerExist = _customers.GetCustomersExits(userRolesCustomerAgent.Customer.Code);
                if (customerExist == true)
                {
                    throw new Exception("Customer already exists");
                }

                userCreated = createUser(userRolesCustomerAgent);
                createCustomer(userRolesCustomerAgent.Customer, userCreated);
            }

            if (userRolesCustomerAgent.Role == SALES_REP)
            {
                SalesRepDto salesRepCreate = userRolesCustomerAgent.SalesRep;
                SalesKamDto salesKamCreate = userRolesCustomerAgent.SalesKam;
                bool insertAgent = false;

                if (salesRepCreate != null)
                {
                    salesRepCreate.Email = userRolesCustomerAgent.User;
                    bool salesRepExist = _salesAgent.GetSalesRepExits(salesRepCreate.NameSalesRep, salesRepCreate.Email);
                    if (salesRepExist == true)
                    {
                        throw new Exception("The Sales rep already exists");
                    }
                    insertAgent = true;
                }

                if (salesKamCreate != null)
                {
                    salesKamCreate.Email = userRolesCustomerAgent.User;
                    bool salesKamExist = _salesKam.GetSalesKamExits(salesKamCreate.NameSalesKam, salesKamCreate.Email);
                    if (salesKamExist == true)
                    {
                        throw new Exception("The Sales kam already exists");
                    }
                    insertAgent = true;
                }

                if (insertAgent)
                {
                    userCreated = createUser(userRolesCustomerAgent);
                    createAgent(salesRepCreate, salesKamCreate);
                }
            }

            if(userCreated == null)
            {
                throw new Exception("User was not created");
            }

            Models.User userResponse = new Models.User();
            userResponse.Id = userCreated.Id;
            userResponse.User1 = userCreated.User1;
            userResponse.FirstName = userCreated.FirstName;
            userResponse.LastName = userCreated.LastName;
            userResponse.Active = userCreated.Active;
            return userResponse;
        }

        private Models.User createUser(UserRolesCustomerAgentDto userRolesCustomerAgent)
        {
            //Crear Usuario
            Models.User userCreate = new Models.User();
            userCreate.User1 = userRolesCustomerAgent.User;
            userCreate.FirstName = userRolesCustomerAgent.FirstName;
            userCreate.LastName = userRolesCustomerAgent.LastName;
            userCreate.Active = userRolesCustomerAgent.Active;
            Models.User userCreated = _user.CreateUser(userCreate);

            //Agregar el rol del usuario
            Models.Role role = _role.GetRoleByName(userRolesCustomerAgent.Role);
            if (role != null)
            {
                Models.RolesByUser roleByUser = new RolesByUser();
                roleByUser.IdUser = userCreated.Id;
                roleByUser.IdRole = role.Id;
                _rolesByUser.CreateRolesByUser(roleByUser);
            }

            return userCreated;
        }

        private void createCustomer(CustomersDto newCustomer, Models.User newUser)
        {
            //Crear customer con el email del usuario
            DateTime now = DateTime.Now;
            CustomersDto customerCreate = newCustomer;
            customerCreate.Email = newUser.User1;
            customerCreate.CreationDate = now;

            Office office = _office.GetOfficeByName(customerCreate.OfficeName);
            if (office != null)
            {
                customerCreate.IdOffice = office.Id;
            }

            Tier tier = _tier.GetByTier(customerCreate.Tier);
            if (tier != null)
            {
                customerCreate.IdTier = tier.Id;
            }

            SalesKam salesKam = _salesKam.GetSalesKamByName(customerCreate.SaleKamName);
            if (salesKam != null)
            {
                customerCreate.IdSalesKam = salesKam.Id;
            }

            SalesRep salesRep = _salesAgent.GetSalesRepByName(customerCreate.SaleAgentName);
            if (salesRep != null)
            {
                customerCreate.IdSalesRep = salesRep.Id;
            }

            Customer customerCreated = _customers.InsertCustomer(customerCreate);

            if (newCustomer.CustomerContacts != null)
            {
                //Crear customer contact
                List<CustomerContactDto> customerContacts = newCustomer.CustomerContacts;
                customerContacts.ForEach(contact =>
                {
                    CustomerContact customerContactCreate = new CustomerContact();
                    customerContactCreate.IdCustomer = customerCreated.Id;
                    customerContactCreate.CreationDate = now;
                    customerContactCreate.FirstName = contact.FirstName;
                    customerContactCreate.LastName = contact.LastName;
                    customerContactCreate.Country = contact.Country;
                    customerContactCreate.State = contact.State;
                    customerContactCreate.Zipcode = contact.Zipcode;
                    customerContactCreate.City = contact.City;
                    customerContactCreate.Phone = contact.Phone;
                    customerContactCreate.Fax = contact.Fax;
                    customerContactCreate.Email = contact.Email;
                    customerContactCreate.ContactType = contact.ContactType;
                    customerContactCreate.Order = contact.Order;

                    _customerContact.InsertCustomerContact(customerContactCreate);
                });
            }

            if (newCustomer.CustomerOffices != null)
            {
                //Crear customer office
                List<CustomerOfficeDto> customerOffices = newCustomer.CustomerOffices;
                customerOffices.ForEach(office =>
                {
                    CustomerOffice customerOfficeCreate = new CustomerOffice();
                    customerOfficeCreate.IdCustomer = customerCreated.Id;
                    customerOfficeCreate.CreationDate = now;
                    customerOfficeCreate.NameCustomerOffice = office.NameCustomerOffice;
                    customerOfficeCreate.Address1 = office.Address1;
                    customerOfficeCreate.Address2 = office.Address2;
                    customerOfficeCreate.Phone = office.Phone;
                    customerOfficeCreate.Fax = office.Fax;
                    customerOfficeCreate.Email = office.Email;
                    customerOfficeCreate.Country = office.Country;
                    customerOfficeCreate.State = office.State;
                    customerOfficeCreate.Zipcode = office.Zipcode;
                    customerOfficeCreate.City = office.City;
                    customerOfficeCreate.Status = office.Status;

                    _customerOffice.InsertCustomerOffice(customerOfficeCreate);
                });
            }
        }

        private void createAgent(SalesRepDto newSalesRep, SalesKamDto newSalesKam)
        {
            if(newSalesRep != null)
            {
                var _map = new apilfs.DTO.MapeoSalesRep();
                _salesAgent.InsertSalesRep(_map.MapearSalesRep(newSalesRep));
            }

            if (newSalesKam != null)
            {
                var _map = new apilfs.DTO.MapeoSalesKam();
                _salesKam.InsertSalesKam(_map.MapearSalesKam(newSalesKam));
            }
        }

        public IConfiguration Configuration { get; }
    }
}
