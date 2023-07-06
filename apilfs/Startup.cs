using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using apilfs.Models;
using apilfs.Repository.Accessorial;
using Microsoft.EntityFrameworkCore;
using apilfs.Repository.Interfaces;
using apilfs.Repository.Customer;
using apilfs.Repository.Mode;
using apilfs.Repository.Commodity;
using System.IO;
using System.Reflection;
using System;
using apilfs.Repository.CongestionNote;
using apilfs.Repository.Port;
using apilfs.Repository.Insurance;
using apilfs.Repository.MexicoRates;
using apilfs.Repository.Drayage;
using apilfs.Repository.Draft;

using apilfs.Services.Interfaces;
using apilfs.Repository.User;
using apilfs.Services.User;
using apilfs.Repository.Role;
using apilfs.Services.Role;
using apilfs.Repository.Permission;
using apilfs.Services.Permission;
using apilfs.Services;
using apilfs.Repository.Quote;

using apilfs.Repository.Quotes;
using apilfs.Servicios.Interfaces;
using apilfs.Servicios.Quotes;
using apilfs.Repository.States;
using apilfs.Repository.TypeTruck;
using apilfs.Repository.Funtions;
using apilfs.Servicios.Draft;
using EmailServices;

namespace apilfs
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<BD_LFSContext>(opt => opt.UseSqlServer(Configuration.GetConnectionString("ConnectionSql")));
            services.AddScoped<IAccesorials, AccesorialsRespository>();
            services.AddScoped<IZipCode, Repository.ZipCodes.ZipCodeRepository>();
            services.AddScoped<ISalesAgent, Repository.SalesRep.SalesRepRespository>();
            services.AddScoped<IVendor, Repository.Vendor.VendorRespository>();
            services.AddScoped<IUnit, Repository.Unit.UnitRepository>();
            services.AddScoped<IModeGroup, Repository.ModeGroup.ModeGroupRepository>();
            services.AddScoped<ICustomers, Repository.Customer.CustomerRepository>();
            services.AddScoped<ICities, Repository.City.CitiesRepository>();
            services.AddScoped<ICountries, Repository.Countries.CountriesRespository>();
            services.AddScoped<ICustomerBySaleAgent, CustomersBySaleAgentRepository>();
            services.AddScoped<IMode, ModeRespository>();
            services.AddScoped<ICommodities, CommoditiesRespository>();
            services.AddScoped<ICongestionNotes, CongestionNoteRepository>();
            services.AddScoped<IPort, PortRepository>();

            services.AddScoped<IInsurance, InsuranceRepository>();           

            services.AddScoped<IMexicoRate, MexicoRateRepository>();

            services.AddScoped<IDrayage, DrayageRepository>();
            services.AddScoped<IDraft, DraftRepository>();     
            services.AddScoped<IUser, UserRepository>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRole, RoleRepository>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IRolesByUser, RolesByUserRepository>();
            services.AddScoped<IRolesByUserService, RolesByUserService>();
            services.AddScoped<IPermission, PermissionRepository>();
            services.AddScoped<IPermissionService, PermissionService>();
            services.AddScoped<IPermissionByRole, PermissionByRoleRepository>();
            services.AddScoped<IPermissionByRoleService, PermissionByRoleService>();
            services.AddScoped<IQuotesServices, QuoteFtlServices>();

            services.AddScoped<IAccessorialsPerQuote, AccessorialsPerQuoteRepository>();
            services.AddScoped<IRatesPerQuote, RatesPerQuoteRepository>();
            services.AddScoped<IBenchmarkRate, BenchmarkRateRepository>();
            services.AddScoped<IQuote, QuoteRepository>();
            services.AddScoped<IExceptionsAppliedPerRate, ExceptionsAppliedPerRateRepository>();
            services.AddScoped<IQuotePartialServices, QuotePartialServices>();
            services.AddScoped<IShipmentsPerQuote, ShipmentsPerQuoteRepository>();

            services.AddScoped<IStates, StateRepository>();

            services.AddScoped<ICustomerOffice, CustomerOfficeRepository>();
            services.AddScoped<ICustomerContact, CustomerContactRepository>();

            services.AddScoped<ITypeTruck, TypeTruckRepository>();

            services.AddScoped<IV_ConfigInsurance, V_ConfigInsuranceRepository>();
                  
            services.AddScoped<ICrossBorderCost, CrossBorderCostRepository>();


            services.AddScoped<IDraftAccesorialsCharge, DraftAccesorialsChargeRepository>();
            services.AddScoped<IDraftCommodity, DraftCommodityRepository>();
            services.AddScoped<IDraftDelivery, DraftDeliveryRepository>();
            services.AddScoped<IDraftInsurance, DraftInsuranceRepository>();
            services.AddScoped<IDraftpickup, DraftpickupRepository>();
            services.AddScoped<IDraftServices, DraftServices>();
            services.AddScoped<IDraftSelectQuote, DraftSelectQuoteRepository>();


            services.AddScoped<IOffice, Repository.Office.OfficeRepository>();
            services.AddScoped<ITier, Repository.Tier.TierRepository>();
            services.AddScoped<ISalesKam, Repository.SaleKam.SaleKamRepository>();
            services.AddScoped<ILeastCostCarriers, LeastCostCarriersRepository>();

            services.AddScoped<IAccessorialsDrayageCost, Repository.DrayageRates.AccessorialsDrayageCostRepository>();
            services.AddScoped<IRatePerQuoteDrayage, RatePerQuoteDrayageRepository>();

            services.AddScoped<IQuoteLtlServices, QuoteLtlServices>();
            services.AddScoped<IQuoteIncServices, QuoteIncServices>();
            services.AddScoped<IAccessorialsPerLeastCostCarriers, AccessorialsPerLeastCostCarriersRepository>();
            services.AddScoped<IQuoteDrayageServices, QuoteDraServices>();
            services.AddScoped<IDraftOfficeCustomer, DraftOfficeCustomerRepository>();
            services.AddScoped<IVCustomerStatus, V_CustomerStatusRepository>();

            var emailConfiguration = Configuration.GetSection("EmailConfiguration").Get<EmailConfiguration>();
            services.AddSingleton(emailConfiguration);
            services.AddScoped<EmailServices.IEmailSender, EmailServices.EmailSender>();
            services.AddScoped<IQuoteHistory, QuoteHistoryRepository>();
            services.AddScoped<IVCustomerBilling, V_CustomerBillingRepository>();
            services.AddScoped<ICustomerRep, CustomerRepRepository>();
            services.AddScoped<IVInvoice, V_InvoiceRepository>();
            services.AddScoped<IVCustomerReceivable, V_CustomerReceivableRepository>();
            services.AddScoped<IVDraftsAll, V_DraftsAllRepository>();

           
            services.AddControllers();           
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "apilfs", Version = "v1" });
                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "apilfs v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }

    internal interface ITxmexicoRepository
    {
    }
}
