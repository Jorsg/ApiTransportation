using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace apilfs.Models
{
    public partial class BD_LFSContext : DbContext
    {
        public BD_LFSContext()
        {
        }

        public BD_LFSContext(DbContextOptions<BD_LFSContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccesorialTypeTruck> AccesorialTypeTrucks { get; set; }
        public virtual DbSet<Accessorial> Accessorials { get; set; }
        public virtual DbSet<AccessorialsCopy> AccessorialsCopies { get; set; }
        public virtual DbSet<AccessorialsDrayageCost> AccessorialsDrayageCosts { get; set; }
        public virtual DbSet<AccessorialsPerLeastCostCarrier> AccessorialsPerLeastCostCarriers { get; set; }
        public virtual DbSet<AccessorialsPerQuote> AccessorialsPerQuotes { get; set; }
        public virtual DbSet<BenchmarkRate> BenchmarkRates { get; set; }
        public virtual DbSet<CitiesTmp> CitiesTmps { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Commodity> Commodities { get; set; }
        public virtual DbSet<CongestionNote> CongestionNotes { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CrossBorderCost> CrossBorderCosts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerContact> CustomerContacts { get; set; }
        public virtual DbSet<CustomerCopium> CustomerCopia { get; set; }
        public virtual DbSet<CustomerOffice> CustomerOffices { get; set; }
        public virtual DbSet<CustomerTmp> CustomerTmps { get; set; }
        public virtual DbSet<Draft> Drafts { get; set; }
        public virtual DbSet<DraftAccesorialsCharge> DraftAccesorialsCharges { get; set; }
        public virtual DbSet<DraftCommodity> DraftCommodities { get; set; }
        public virtual DbSet<DraftDelivery> DraftDeliveries { get; set; }
        public virtual DbSet<DraftInsurance> DraftInsurances { get; set; }
        public virtual DbSet<DraftOfficeCustomer> DraftOfficeCustomers { get; set; }
        public virtual DbSet<DraftPickup> DraftPickups { get; set; }
        public virtual DbSet<DraftSelectedQuote> DraftSelectedQuotes { get; set; }
        public virtual DbSet<Drayage> Drayages { get; set; }
        public virtual DbSet<ExceptionsAppliedPerRate> ExceptionsAppliedPerRates { get; set; }
        public virtual DbSet<Insurance> Insurances { get; set; }
        public virtual DbSet<Lane> Lanes { get; set; }
        public virtual DbSet<LeastCostCarrier> LeastCostCarriers { get; set; }
        public virtual DbSet<MexicoRate> MexicoRates { get; set; }
        public virtual DbSet<Mode> Modes { get; set; }
        public virtual DbSet<ModeGroup> ModeGroups { get; set; }
        public virtual DbSet<Office> Offices { get; set; }
        public virtual DbSet<Permission> Permissions { get; set; }
        public virtual DbSet<PermissionsByRole> PermissionsByRoles { get; set; }
        public virtual DbSet<PortsRamp> PortsRamps { get; set; }
        public virtual DbSet<Quote> Quotes { get; set; }
        public virtual DbSet<QuotesTmp> QuotesTmps { get; set; }
        public virtual DbSet<RatesPerQuote> RatesPerQuotes { get; set; }
        public virtual DbSet<RatesPerQuoteDrayage> RatesPerQuoteDrayages { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RolesByUser> RolesByUsers { get; set; }
        public virtual DbSet<SalesKam> SalesKams { get; set; }
        public virtual DbSet<SalesRep> SalesReps { get; set; }
        public virtual DbSet<ServiceMode> ServiceModes { get; set; }
        public virtual DbSet<ShipmentsPerQuote> ShipmentsPerQuotes { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<Tier> Tiers { get; set; }
        public virtual DbSet<TypeTruck> TypeTrucks { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UsersCopium> UsersCopia { get; set; }
        public virtual DbSet<VConfigInsurance> VConfigInsurances { get; set; }
        public virtual DbSet<VCustomerBilling> VCustomerBillings { get; set; }
        public virtual DbSet<VCustomerReceivable> VCustomerReceivables { get; set; }
        public virtual DbSet<VCustomerRep> VCustomerReps { get; set; }
        public virtual DbSet<VCustomerStatus> VCustomerStatuses { get; set; }
        public virtual DbSet<VDraft> VDrafts { get; set; }
        public virtual DbSet<VDraftsAll> VDraftsAlls { get; set; }
        public virtual DbSet<VInvoice> VInvoices { get; set; }
        public virtual DbSet<VQuoteHistory> VQuoteHistories { get; set; }
        public virtual DbSet<Vendor> Vendors { get; set; }
        public virtual DbSet<ZipCode> ZipCodes { get; set; }
        public virtual DbSet<ZipCodesTmp> ZipCodesTmps { get; set; }
        public virtual DbSet<Zipcodecanadum> Zipcodecanada { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=40.65.109.191,1401;Database=BD_LFS;User Id = jsaldarriaga@lfs-inc.com; Password=kUuhy%SenE%3;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AccesorialTypeTruck>(entity =>
            {
                entity.ToTable("AccesorialTypeTruck");

                entity.HasOne(d => d.IdAccesorialNavigation)
                    .WithMany(p => p.AccesorialTypeTrucks)
                    .HasForeignKey(d => d.IdAccesorial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccesorialTypeTruck_Accessorials");

                entity.HasOne(d => d.IdTypeTruckNavigation)
                    .WithMany(p => p.AccesorialTypeTrucks)
                    .HasForeignKey(d => d.IdTypeTruck)
                    .HasConstraintName("FK_AccesorialTypeTruck_TypeTruck");
            });

            modelBuilder.Entity<Accessorial>(entity =>
            {
                entity.HasIndex(e => e.AccessorialCode, "KEY_Accessorials_AccessorialCode")
                    .IsUnique();

                entity.Property(e => e.AccessorialCode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CheckAccesorials).HasColumnName("checkAccesorials");

                entity.Property(e => e.Cost).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.IdModegroup).HasDefaultValueSql("((-1))");

                entity.Property(e => e.IdSaas)
                    .HasMaxLength(100)
                    .HasColumnName("IdSAAS");

                entity.Property(e => e.IdSwanLeap).HasMaxLength(100);

                entity.Property(e => e.IdYat)
                    .HasMaxLength(100)
                    .HasColumnName("IdYAT");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameSaas)
                    .HasMaxLength(100)
                    .HasColumnName("NameSAAS");

                entity.Property(e => e.NameSwanLeap).HasMaxLength(100);

                entity.Property(e => e.NameYat)
                    .HasMaxLength(100)
                    .HasColumnName("NameYAT");

                entity.Property(e => e.Type).HasMaxLength(100);

                entity.HasOne(d => d.IdModegroupNavigation)
                    .WithMany(p => p.Accessorials)
                    .HasForeignKey(d => d.IdModegroup)
                    .HasConstraintName("FK_Accessorials_ModeGroup");
            });

            modelBuilder.Entity<AccessorialsCopy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Accessorials_copy");

                entity.Property(e => e.AccessorialCode)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CheckAccesorials).HasColumnName("checkAccesorials");

                entity.Property(e => e.Cost).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IdSaas)
                    .HasMaxLength(100)
                    .HasColumnName("IdSAAS");

                entity.Property(e => e.IdSwanLeap).HasMaxLength(100);

                entity.Property(e => e.IdYat)
                    .HasMaxLength(100)
                    .HasColumnName("IdYAT");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameSaas)
                    .HasMaxLength(100)
                    .HasColumnName("NameSAAS");

                entity.Property(e => e.NameSwanLeap).HasMaxLength(100);

                entity.Property(e => e.NameYat)
                    .HasMaxLength(100)
                    .HasColumnName("NameYAT");

                entity.Property(e => e.Type).HasMaxLength(100);
            });

            modelBuilder.Entity<AccessorialsDrayageCost>(entity =>
            {
                entity.Property(e => e.Accessorial)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cost).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<AccessorialsPerLeastCostCarrier>(entity =>
            {
                entity.Property(e => e.AccessorialDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Charge).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.IdAccessorialNavigation)
                    .WithMany(p => p.AccessorialsPerLeastCostCarriers)
                    .HasForeignKey(d => d.IdAccessorial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("AccessorialsPerLeastCostCarriers_FK_Accessorials");

                entity.HasOne(d => d.IdLeastCostCarrierNavigation)
                    .WithMany(p => p.AccessorialsPerLeastCostCarriers)
                    .HasForeignKey(d => d.IdLeastCostCarrier)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("AccessorialsPerLeastCostCarriers_FK_LeastCostCarrier");
            });

            modelBuilder.Entity<AccessorialsPerQuote>(entity =>
            {
                entity.ToTable("AccessorialsPerQuote");

                entity.Property(e => e.Price).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.IdAccessorialNavigation)
                    .WithMany(p => p.AccessorialsPerQuotes)
                    .HasForeignKey(d => d.IdAccessorial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccessorialsPerQuote_IdAccessorials");

                entity.HasOne(d => d.IdQuoteNavigation)
                    .WithMany(p => p.AccessorialsPerQuotes)
                    .HasForeignKey(d => d.IdQuote)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccessorialsPerQuote_IdQuote");
            });

            modelBuilder.Entity<BenchmarkRate>(entity =>
            {
                entity.ToTable("BenchmarkRate");

                entity.Property(e => e.BenchmarkAllInRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BenchmarkFuelRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BenchmarkLinehaulRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BenchmarkPmAllInRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BenchmarkPmFuelRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.BenchmarkPmLinehaulRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ConfidenceLevel).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Contributors).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CostBasisAllInRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CostBasisFuelRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CostBasisHighAllInRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CostBasisHighLinehaulRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CostBasisHighPmAllInRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CostBasisHighPmLinehaulRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CostBasisLinehaulRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CostBasisLowAllInRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CostBasisLowLinehaulRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CostBasisLowPmAllInRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CostBasisLowPmLinehaulRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CostBasisPmAllInRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CostBasisPmFuelRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CostBasisPmLinehaulRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DaysBack).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.HighBenchmarkAllInRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.HighBenchmarkLinehaulRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.HighBenchmarkPmAllInRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.HighBenchmarkPmLinehaulRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.LowBenchmarkAllInRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.LowBenchmarkLinehaulRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.LowBenchmarkPmAllInRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.LowBenchmarkPmLinehaulRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MetroLaneMileage).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Moves).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RatedLaneDest).HasMaxLength(255);

                entity.Property(e => e.RatedLaneOrig).HasMaxLength(255);

                entity.HasOne(d => d.IdQuoteNavigation)
                    .WithMany(p => p.BenchmarkRates)
                    .HasForeignKey(d => d.IdQuote)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("BenchmarkRate_FK");
            });

            modelBuilder.Entity<CitiesTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Cities_tmp");

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.DaylightSaving).HasMaxLength(2);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.StateCode)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.TimeZone).HasMaxLength(2);
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.DaylightSaving).HasMaxLength(2);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.TimeZone).HasMaxLength(2);

                entity.HasOne(d => d.IdStateNavigation)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.IdState)
                    .HasConstraintName("FK_Cities_States");
            });

            modelBuilder.Entity<Commodity>(entity =>
            {
                entity.HasKey(e => e.CodeCommodities)
                    .HasName("PK_Commodities_CodeCommodities");

                entity.Property(e => e.CodeCommodities).HasMaxLength(10);

                entity.Property(e => e.Name).HasMaxLength(250);
            });

            modelBuilder.Entity<CongestionNote>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Note1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Note2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Note3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Note4)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Note5Internal)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PortRamp)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rate1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rate1Percentage).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rate2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rate2Percentage).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rate3)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rate3Percentage).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.IdZipcodeNavigation)
                    .WithMany(p => p.CongestionNotes)
                    .HasForeignKey(d => d.IdZipcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CongestionNotes_FK");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_Countries_Id")
                    .IsClustered(false);

                entity.HasIndex(e => e.Iso2Code, "IDX_Country_CodeIso")
                    .IsClustered();

                entity.HasIndex(e => e.Iso2Code, "Index_Countries_Iso2Code")
                    .IsUnique();

                entity.HasIndex(e => e.Iso2Code, "KEY_Countries_Iso2Code")
                    .IsUnique();

                entity.Property(e => e.Iso2Code)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.Iso3Code).HasMaxLength(3);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.NameTitleCase).HasMaxLength(100);

                entity.Property(e => e.NumCode).HasMaxLength(5);

                entity.Property(e => e.PhoneCode).HasMaxLength(5);
            });

            modelBuilder.Entity<CrossBorderCost>(entity =>
            {
                entity.Property(e => e.Cost).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.IdTypeTruckNavigation)
                    .WithMany(p => p.CrossBorderCosts)
                    .HasForeignKey(d => d.IdTypeTruck)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("CrossBorderCosts_FK_TypeTruck");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.HasIndex(e => e.Code, "Customer_UN")
                    .IsUnique();

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Address1).HasMaxLength(200);

                entity.Property(e => e.Address2).HasMaxLength(200);

                entity.Property(e => e.Arrepresentative)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ARRepresentative");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.ClientCodeSaas)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Company).HasMaxLength(10);

                entity.Property(e => e.CompanyDomain).HasMaxLength(200);

                entity.Property(e => e.Country).HasMaxLength(10);

                entity.Property(e => e.CreationDate).HasColumnType("date");

                entity.Property(e => e.CreditLimit).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CreditTerms).HasMaxLength(50);

                entity.Property(e => e.CustomerGroup).HasMaxLength(150);

                entity.Property(e => e.CustomerIdYat)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(800);

                entity.Property(e => e.Fax).HasMaxLength(15);

                entity.Property(e => e.IdClientSwanleap)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdOffice).HasDefaultValueSql("((-1))");

                entity.Property(e => e.IdSalesKam).HasDefaultValueSql("((-1))");

                entity.Property(e => e.IdSalesRep).HasDefaultValueSql("((-1))");

                entity.Property(e => e.IdTier).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Kam).HasMaxLength(50);

                entity.Property(e => e.LinkedinCompanyPage).HasMaxLength(200);

                entity.Property(e => e.MajorCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MajorName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NameCustomer).HasMaxLength(100);

                entity.Property(e => e.OfficeAssigned).HasMaxLength(50);

                entity.Property(e => e.PasswordFrontEnd)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone).HasMaxLength(15);

                entity.Property(e => e.Profile).HasMaxLength(50);

                entity.Property(e => e.ProfileCodeSaas)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rep).HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(20);

                entity.Property(e => e.StatusCustomer).HasMaxLength(10);

                entity.Property(e => e.Tier).HasMaxLength(50);

                entity.Property(e => e.UserFrontEnd)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserProfile)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.W9Rfc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("W9-RFC");

                entity.Property(e => e.WebsiteUrl).HasMaxLength(200);

                entity.Property(e => e.ZipCode).HasMaxLength(10);

                entity.HasOne(d => d.IdOfficeNavigation)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.IdOffice)
                    .HasConstraintName("FK_Customer_Office");

                entity.HasOne(d => d.IdSalesKamNavigation)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.IdSalesKam)
                    .HasConstraintName("FK_Customer_SalesKam");

                entity.HasOne(d => d.IdSalesRepNavigation)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.IdSalesRep)
                    .HasConstraintName("FK_Customer_SalesRep");

                entity.HasOne(d => d.IdTierNavigation)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.IdTier)
                    .HasConstraintName("FK_Customer_Tier");
            });

            modelBuilder.Entity<CustomerContact>(entity =>
            {
                entity.ToTable("CustomerContact");

                entity.Property(e => e.City).HasMaxLength(150);

                entity.Property(e => e.ContactType).HasMaxLength(100);

                entity.Property(e => e.Country).HasMaxLength(10);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.Fax).HasMaxLength(25);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.IdB2c)
                    .HasMaxLength(100)
                    .HasColumnName("IdB2C");

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.Phone).HasMaxLength(25);

                entity.Property(e => e.State).HasMaxLength(10);

                entity.Property(e => e.Zipcode).HasMaxLength(10);

                entity.HasOne(d => d.IdCustomerNavigation)
                    .WithMany(p => p.CustomerContacts)
                    .HasForeignKey(d => d.IdCustomer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerContact_Customer");
            });

            modelBuilder.Entity<CustomerCopium>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("customer_copia");

                entity.Property(e => e.Address1).HasMaxLength(200);

                entity.Property(e => e.Address2).HasMaxLength(200);

                entity.Property(e => e.Arrepresentative)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ARRepresentative");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.ClientCodeSaas)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Company).HasMaxLength(10);

                entity.Property(e => e.CompanyDomain).HasMaxLength(200);

                entity.Property(e => e.Country).HasMaxLength(10);

                entity.Property(e => e.CreationDate).HasColumnType("date");

                entity.Property(e => e.CreditLimit).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CreditTerms).HasMaxLength(50);

                entity.Property(e => e.CustomerGroup).HasMaxLength(50);

                entity.Property(e => e.CustomerIdYat)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(800);

                entity.Property(e => e.Fax).HasMaxLength(15);

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.IdClientSwanleap)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdCustomerCode)
                    .HasMaxLength(20)
                    .HasColumnName("idCustomerCode");

                entity.Property(e => e.Kam).HasMaxLength(50);

                entity.Property(e => e.LinkedinCompanyPage).HasMaxLength(200);

                entity.Property(e => e.MajorCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MajorName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NameCustomer).HasMaxLength(100);

                entity.Property(e => e.OfficeAssigned).HasMaxLength(50);

                entity.Property(e => e.PasswordFrontEnd)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone).HasMaxLength(15);

                entity.Property(e => e.Profile).HasMaxLength(50);

                entity.Property(e => e.ProfileCodeSaas)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rep).HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(20);

                entity.Property(e => e.StatusCustomer).HasMaxLength(10);

                entity.Property(e => e.Tier).HasMaxLength(50);

                entity.Property(e => e.UserFrontEnd)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserProfile)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.W9Rfc)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("W9-RFC");

                entity.Property(e => e.WebsiteUrl).HasMaxLength(200);

                entity.Property(e => e.ZipCode).HasMaxLength(10);
            });

            modelBuilder.Entity<CustomerOffice>(entity =>
            {
                entity.ToTable("CustomerOffice");

                entity.Property(e => e.Address1).HasMaxLength(200);

                entity.Property(e => e.Address2).HasMaxLength(200);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.Country).HasMaxLength(10);

                entity.Property(e => e.CreationDate).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(800);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.NameCustomerOffice).HasMaxLength(100);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(10);

                entity.Property(e => e.Status).HasMaxLength(20);

                entity.Property(e => e.Zipcode).HasMaxLength(15);

                entity.HasOne(d => d.IdCustomerNavigation)
                    .WithMany(p => p.CustomerOffices)
                    .HasForeignKey(d => d.IdCustomer)
                    .HasConstraintName("FK_CustomerOffice_CustomerOffice");
            });

            modelBuilder.Entity<CustomerTmp>(entity =>
            {
                entity.HasKey(e => e.Idcustomer)
                    .HasName("PK_Customer_IDCustomer");

                entity.ToTable("Customer_Tmp");

                entity.Property(e => e.Idcustomer).HasColumnName("IDCustomer");

                entity.Property(e => e.Active).HasMaxLength(255);

                entity.Property(e => e.Address1).HasMaxLength(255);

                entity.Property(e => e.Address2).HasMaxLength(255);

                entity.Property(e => e.Arcode)
                    .HasMaxLength(255)
                    .HasColumnName("ARCode");

                entity.Property(e => e.BillingCode).HasMaxLength(255);

                entity.Property(e => e.CloseTime).HasMaxLength(255);

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CodeCity).HasMaxLength(10);

                entity.Property(e => e.CodeCountry).HasMaxLength(10);

                entity.Property(e => e.CodeOfficeAssigned).HasMaxLength(10);

                entity.Property(e => e.CodeSalesKam).HasMaxLength(10);

                entity.Property(e => e.CodeSalesRep).HasMaxLength(10);

                entity.Property(e => e.CodeState).HasMaxLength(10);

                entity.Property(e => e.CodeTier).HasMaxLength(10);

                entity.Property(e => e.CodeZipcode).HasMaxLength(10);

                entity.Property(e => e.Company).HasMaxLength(20);

                entity.Property(e => e.Contact).HasMaxLength(255);

                entity.Property(e => e.Contacts).HasMaxLength(4000);

                entity.Property(e => e.ControlPerson).HasMaxLength(255);

                entity.Property(e => e.Created).HasMaxLength(255);

                entity.Property(e => e.CreditLimit).HasMaxLength(255);

                entity.Property(e => e.CreditStatus).HasMaxLength(50);

                entity.Property(e => e.Customer).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(1000);

                entity.Property(e => e.Fax).HasMaxLength(255);

                entity.Property(e => e.InsideSalesRep).HasMaxLength(255);

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.Locked).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(255);

                entity.Property(e => e.OpenTime).HasMaxLength(255);

                entity.Property(e => e.Phone).HasMaxLength(255);

                entity.Property(e => e.Phone2).HasMaxLength(255);

                entity.Property(e => e.Profile).HasMaxLength(255);

                entity.Property(e => e.RatingApplet).HasMaxLength(255);

                entity.Property(e => e.Remarks).HasMaxLength(4000);

                entity.Property(e => e.RemitToSl)
                    .HasMaxLength(255)
                    .HasColumnName("RemitToSL");

                entity.Property(e => e.ShippingLocation).HasMaxLength(255);

                entity.Property(e => e.Terms).HasMaxLength(255);

                entity.Property(e => e.UserFront).HasMaxLength(50);
            });

            modelBuilder.Entity<Draft>(entity =>
            {
                entity.ToTable("Draft");

                entity.Property(e => e.AcceptedTC).HasColumnName("acceptedT&C");

                entity.Property(e => e.BolSwanleap)
                    .HasMaxLength(100)
                    .HasColumnName("bolSwanleap");

                entity.Property(e => e.BookWithAgent).HasColumnName("bookWithAgent");

                entity.Property(e => e.CustomerBillingReference).HasMaxLength(50);

                entity.Property(e => e.CustomerId).HasColumnName("customerId");

                entity.Property(e => e.Hazmat).HasColumnName("hazmat");

                entity.Property(e => e.ModeGroup)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("modeGroup");

                entity.Property(e => e.SpecialInstructions)
                    .HasMaxLength(4000)
                    .HasColumnName("specialInstructions");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.TrailerLength).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Weight)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("weight");
            });

            modelBuilder.Entity<DraftAccesorialsCharge>(entity =>
            {
                entity.Property(e => e.AccessorialCharge)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("accessorialCharge");

                entity.Property(e => e.AccessorialCode)
                    .HasMaxLength(100)
                    .HasColumnName("accessorialCode");

                entity.Property(e => e.AccessorialCode1)
                    .HasMaxLength(100)
                    .HasColumnName("accessorial_code");

                entity.Property(e => e.AccessorialDescription)
                    .HasMaxLength(100)
                    .HasColumnName("accessorialDescription");

                entity.Property(e => e.AccessorialName)
                    .HasMaxLength(100)
                    .HasColumnName("accessorial_name");

                entity.Property(e => e.DefaultRate)
                    .HasColumnType("decimal(38, 0)")
                    .HasColumnName("default_rate");
            });

            modelBuilder.Entity<DraftCommodity>(entity =>
            {
                entity.Property(e => e.CommodityClass)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("commodityClass");

                entity.Property(e => e.CrossBorder).HasColumnName("crossBorder");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");

                entity.Property(e => e.Hazmat).HasColumnName("hazmat");

                entity.Property(e => e.HazmatClass)
                    .HasMaxLength(100)
                    .HasColumnName("hazmatClass");

                entity.Property(e => e.Height)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("height");

                entity.Property(e => e.Length)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("length");

                entity.Property(e => e.ParkingGroup)
                    .HasMaxLength(100)
                    .HasColumnName("parkingGroup");

                entity.Property(e => e.Quantity)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("quantity");

                entity.Property(e => e.TeamService).HasColumnName("teamService");

                entity.Property(e => e.UnNumber)
                    .HasMaxLength(100)
                    .HasColumnName("unNumber");

                entity.Property(e => e.Unit)
                    .HasMaxLength(20)
                    .HasColumnName("unit");

                entity.Property(e => e.Weight)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("weight");

                entity.Property(e => e.Width)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("width");
            });

            modelBuilder.Entity<DraftDelivery>(entity =>
            {
                entity.ToTable("DraftDelivery");

                entity.Property(e => e.Accesorials).HasMaxLength(100);

                entity.Property(e => e.AddreesType)
                    .HasMaxLength(50)
                    .HasColumnName("addreesType");

                entity.Property(e => e.ContactName).HasMaxLength(100);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .HasColumnName("country");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FinalDate)
                    .HasColumnType("datetime")
                    .HasColumnName("finalDate");

                entity.Property(e => e.FinalTime)
                    .HasColumnType("time(3)")
                    .HasColumnName("finalTime");

                entity.Property(e => e.InitialDate)
                    .HasColumnType("datetime")
                    .HasColumnName("initialDate");

                entity.Property(e => e.InitialTime)
                    .HasColumnType("time(3)")
                    .HasColumnName("initialTime");

                entity.Property(e => e.LocationName)
                    .HasMaxLength(100)
                    .HasColumnName("locationName");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Reference)
                    .HasMaxLength(100)
                    .HasColumnName("reference");

                entity.Property(e => e.SpecialIntruction).HasMaxLength(1000);

                entity.Property(e => e.Street).HasMaxLength(100);

                entity.Property(e => e.Street2).HasMaxLength(100);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(50)
                    .HasColumnName("zipCode");
            });

            modelBuilder.Entity<DraftInsurance>(entity =>
            {
                entity.ToTable("DraftInsurance");

                entity.Property(e => e.CargoInsuran)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("cargoInsuran");

                entity.Property(e => e.CargoInsuranceActive).HasColumnName("cargoInsuranceActive");

                entity.Property(e => e.CargoOwnerCountry).HasMaxLength(100);

                entity.Property(e => e.CommodityType).HasMaxLength(50);

                entity.Property(e => e.InsureFreight).HasColumnName("insureFreight");

                entity.Property(e => e.InsuredCargoOwner).HasMaxLength(100);

                entity.Property(e => e.MinInsuredCost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("minInsuredCost");

                entity.Property(e => e.TotalCargoValue).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<DraftOfficeCustomer>(entity =>
            {
                entity.ToTable("DraftOfficeCustomer");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .HasColumnName("city");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .HasColumnName("country");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.LocationId)
                    .HasMaxLength(100)
                    .HasColumnName("locationId");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasColumnName("phone");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .HasColumnName("state");

                entity.Property(e => e.Street1)
                    .HasMaxLength(100)
                    .HasColumnName("street1");

                entity.Property(e => e.Zip)
                    .HasMaxLength(20)
                    .HasColumnName("zip");
            });

            modelBuilder.Entity<DraftPickup>(entity =>
            {
                entity.ToTable("DraftPickup");

                entity.Property(e => e.Accesorials).HasMaxLength(100);

                entity.Property(e => e.AddreesType)
                    .HasMaxLength(50)
                    .HasColumnName("addreesType");

                entity.Property(e => e.ContactName).HasMaxLength(100);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .HasColumnName("country");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FinalDate)
                    .HasColumnType("datetime")
                    .HasColumnName("finalDate");

                entity.Property(e => e.FinalTime)
                    .HasColumnType("time(3)")
                    .HasColumnName("finalTime");

                entity.Property(e => e.InitialDate)
                    .HasColumnType("datetime")
                    .HasColumnName("initialDate");

                entity.Property(e => e.InitialTime)
                    .HasColumnType("time(3)")
                    .HasColumnName("initialTime");

                entity.Property(e => e.LocationName)
                    .HasMaxLength(100)
                    .HasColumnName("locationName");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Reference)
                    .HasMaxLength(100)
                    .HasColumnName("reference");

                entity.Property(e => e.SpecialIntruction).HasMaxLength(1000);

                entity.Property(e => e.Street).HasMaxLength(100);

                entity.Property(e => e.Street2).HasMaxLength(100);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(50)
                    .HasColumnName("zipCode");
            });

            modelBuilder.Entity<DraftSelectedQuote>(entity =>
            {
                entity.ToTable("DraftSelectedQuote");

                entity.Property(e => e.AccessorialCost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("accessorial_cost");

                entity.Property(e => e.AllInPlusAccessorialRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("all_in_plus_accessorial_rate");

                entity.Property(e => e.AllInRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("all_in_rate");

                entity.Property(e => e.CargoInsurance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("cargoInsurance");

                entity.Property(e => e.CarrierId).HasColumnName("carrierId");

                entity.Property(e => e.CarrierQuoteNumber).HasMaxLength(50);

                entity.Property(e => e.DeliveryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("deliveryDate");

                entity.Property(e => e.DirectRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("direct_rate");

                entity.Property(e => e.DirectRateCargoInsurance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("direct_rate_cargo_insurance");

                entity.Property(e => e.DirectRateMinInsuredCost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("direct_rate_min_insured_cost");

                entity.Property(e => e.DirectRateNetPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("direct_rate_net_price");

                entity.Property(e => e.DirectRateOperation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direct_rate_operation");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discount");

                entity.Property(e => e.ForPickupAfter)
                    .HasColumnType("datetime")
                    .HasColumnName("for_pickup_after");

                entity.Property(e => e.ForPickupBy)
                    .HasColumnType("datetime")
                    .HasColumnName("for_pickup_by");

                entity.Property(e => e.FuelRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("fuel_rate");

                entity.Property(e => e.FuelSurcharge)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("fuelSurcharge");

                entity.Property(e => e.GrossCharge)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("grossCharge");

                entity.Property(e => e.LinehaulRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("linehaul_rate");

                entity.Property(e => e.MinInsuredCost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("minInsuredCost");

                entity.Property(e => e.NetCharge)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("netCharge");

                entity.Property(e => e.NetPricesAccessorialCharges)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("netPricesAccessorialCharges");

                entity.Property(e => e.NetPricesDiscount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("netPricesDiscount");

                entity.Property(e => e.NetPricesFuelSurcharge)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("netPricesFuelSurcharge");

                entity.Property(e => e.NetPricesGrossCharge)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("netPricesGrossCharge");

                entity.Property(e => e.NetPricesTotalShipmentCost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("netPricesTotalShipmentCost");

                entity.Property(e => e.Rate)
                    .HasMaxLength(50)
                    .HasColumnName("rate");

                entity.Property(e => e.RateId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("rateId");

                entity.Property(e => e.Scac)
                    .HasMaxLength(100)
                    .HasColumnName("scac");

                entity.Property(e => e.SelectedMexicoRate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("selectedMexicoRate");

                entity.Property(e => e.ServiceLevelDescription)
                    .HasMaxLength(100)
                    .HasColumnName("serviceLevelDescription");

                entity.Property(e => e.StrikeAccessorialCost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("strike_accessorial_cost");

                entity.Property(e => e.StrikeAllInPlusAccessorialRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("strike_all_in_plus_accessorial_rate");

                entity.Property(e => e.StrikeAllInRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("strike_all_in_rate");

                entity.Property(e => e.StrikeFuelRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("strike_fuel_rate");

                entity.Property(e => e.StrikeLinehaulRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("strike_linehaul_rate");

                entity.Property(e => e.TotalCost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalCost");

                entity.Property(e => e.TotalShipmentCost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalShipmentCost");

                entity.Property(e => e.TransbordRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("transbord_rate");

                entity.Property(e => e.TransbordRateCargoInsurance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("transbord_rate_cargo_insurance");

                entity.Property(e => e.TransbordRateMinInsuredCost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("transbord_rate_min_insured_cost");

                entity.Property(e => e.TransbordRateNetPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("transbord_rate_net_price");

                entity.Property(e => e.TransbordRateOperation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transbord_rate_operation");

                entity.Property(e => e.TransitDays).HasColumnName("transitDays");
            });

            modelBuilder.Entity<Drayage>(entity =>
            {
                entity.ToTable("Drayage");

                entity.Property(e => e.Notes)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Option1)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Option2)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Option3)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PorceOption1)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PorceOption2)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PorceOption3)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ValorTarifaApi).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdCustomerNavigation)
                    .WithMany(p => p.Drayages)
                    .HasForeignKey(d => d.IdCustomer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Drayage_Customer");

                entity.HasOne(d => d.IdPortRampNavigation)
                    .WithMany(p => p.Drayages)
                    .HasForeignKey(d => d.IdPortRamp)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Drayage_PortsRamps");

                entity.HasOne(d => d.IdVendorNavigation)
                    .WithMany(p => p.Drayages)
                    .HasForeignKey(d => d.IdVendor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Drayage_Vendor");
            });

            modelBuilder.Entity<ExceptionsAppliedPerRate>(entity =>
            {
                entity.ToTable("ExceptionsAppliedPerRate");

                entity.Property(e => e.AllInRateDelta).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CustomerOrCarrier)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ExceptionName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FuelRateDelta).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.LinehaulRateDelta).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Mode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Value).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.IdRateNavigation)
                    .WithMany(p => p.ExceptionsAppliedPerRates)
                    .HasForeignKey(d => d.IdRate)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ExceptionsAppliedPerRate_FK");
            });

            modelBuilder.Entity<Insurance>(entity =>
            {
                entity.ToTable("Insurance");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Formula).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MaxValorCarga).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MinCostAsegurado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MinValorCarga).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Porcentaje).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.TipoMercancia)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ValorMaximoMinima).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ValorMinima).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdCustomerNavigation)
                    .WithMany(p => p.Insurances)
                    .HasForeignKey(d => d.IdCustomer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Insurance_Insurance");

                entity.HasOne(d => d.IdModeGroupNavigation)
                    .WithMany(p => p.Insurances)
                    .HasForeignKey(d => d.IdModeGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Insurance_FK_ModeGroup");

                entity.HasOne(d => d.IdTierNavigation)
                    .WithMany(p => p.Insurances)
                    .HasForeignKey(d => d.IdTier)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Insurance_Tier");
            });

            modelBuilder.Entity<Lane>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_Lane_CodeLane")
                    .IsClustered(false);

                entity.ToTable("Lane");

                entity.HasIndex(e => e.Id, "UK_Lane_CodeLane")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.FromCountry)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.FromState)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.FromZip)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Miles).HasColumnType("numeric(18, 8)");

                entity.Property(e => e.MilesList).HasMaxLength(500);

                entity.Property(e => e.ToCountry)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ToState)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.ToZip)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Toll).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<LeastCostCarrier>(entity =>
            {
                entity.Property(e => e.ApiCallDuration)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CargoInsurance).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CarrierQuoteNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DeliveryDate).HasColumnType("date");

                entity.Property(e => e.Discount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DiscountRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.FuelSurcharge).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.GrossCharge).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MinInsuredCost).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ModeDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NetCharge).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RateId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TotalShipmentCost).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TransitDays).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.IdModeNavigation)
                    .WithMany(p => p.LeastCostCarriers)
                    .HasForeignKey(d => d.IdMode)
                    .HasConstraintName("LeastCostCarriers_FK_Mode");

                entity.HasOne(d => d.IdQuoteNavigation)
                    .WithMany(p => p.LeastCostCarriers)
                    .HasForeignKey(d => d.IdQuote)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("LeastCostCarriers_FK_Quote");

                entity.HasOne(d => d.IdVendorNavigation)
                    .WithMany(p => p.LeastCostCarriers)
                    .HasForeignKey(d => d.IdVendor)
                    .HasConstraintName("LeastCostCarriers_FK_Vendor");
            });

            modelBuilder.Entity<MexicoRate>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CityFrom)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CityTo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cost).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Empty).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Operation)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Sale).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Tt)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("TT");

                entity.HasOne(d => d.IdCityFromNavigation)
                    .WithMany(p => p.MexicoRateIdCityFromNavigations)
                    .HasForeignKey(d => d.IdCityFrom)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MexicoRates_FK_CityFrom");

                entity.HasOne(d => d.IdCityToNavigation)
                    .WithMany(p => p.MexicoRateIdCityToNavigations)
                    .HasForeignKey(d => d.IdCityTo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MexicoRates_FK_CityTo");

                entity.HasOne(d => d.IdServiceModeNavigation)
                    .WithMany(p => p.MexicoRates)
                    .HasForeignKey(d => d.IdServiceMode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MexicoRates_FK_ServiceMode");

                entity.HasOne(d => d.IdTypeTruckNavigation)
                    .WithMany(p => p.MexicoRates)
                    .HasForeignKey(d => d.IdTypeTruck)
                    .HasConstraintName("MexicoRates_FK_TypeTruck");
            });

            modelBuilder.Entity<Mode>(entity =>
            {
                entity.ToTable("Mode");

                entity.Property(e => e.Company).HasMaxLength(50);

                entity.Property(e => e.Mode1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Mode");

                entity.Property(e => e.ModeGroup)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ServiceLevelSaas)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceLevelSwanleap)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceLevelYat)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.ModeGroupNavigation)
                    .WithMany(p => p.Modes)
                    .HasPrincipalKey(p => p.IdModeGroup)
                    .HasForeignKey(d => d.ModeGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mode_ModeGroup");
            });

            modelBuilder.Entity<ModeGroup>(entity =>
            {
                entity.ToTable("ModeGroup");

                entity.HasIndex(e => e.IdModeGroup, "KEY_ModeGroup_ModeGroup")
                    .IsUnique();

                entity.Property(e => e.BusinessUnit)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Company).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.IdModeGroup)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModeType)
                    .IsRequired()
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<Office>(entity =>
            {
                entity.ToTable("Office");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CountryCode).HasMaxLength(5);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.FullName).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Phone).HasMaxLength(10);

                entity.Property(e => e.StateCode).HasMaxLength(5);

                entity.Property(e => e.ZipCode).HasMaxLength(10);
            });

            modelBuilder.Entity<Permission>(entity =>
            {
                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PermissionsByRole>(entity =>
            {
                entity.HasOne(d => d.IdPermissionNavigation)
                    .WithMany(p => p.PermissionsByRoles)
                    .HasForeignKey(d => d.IdPermission)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PermissionsByRoles_FK_Permissions");

                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.PermissionsByRoles)
                    .HasForeignKey(d => d.IdRole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("PermissionsByRoles_FK_Roles");
            });

            modelBuilder.Entity<PortsRamp>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_Ports_Ramps_Id")
                    .IsClustered(false);

                entity.HasIndex(e => e.Id, "UK_Ports_CodePort")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.IdZipcode).HasDefaultValueSql("((-1))");

                entity.Property(e => e.Messages).HasMaxLength(4000);

                entity.Property(e => e.StateCode)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.IdZipcodeNavigation)
                    .WithMany(p => p.PortsRamps)
                    .HasForeignKey(d => d.IdZipcode)
                    .HasConstraintName("FK_PortsRamps_ZipCodes");
            });

            modelBuilder.Entity<Quote>(entity =>
            {
                entity.Property(e => e.CityFrom).HasMaxLength(255);

                entity.Property(e => e.CityTo).HasMaxLength(255);

                entity.Property(e => e.DateQuote).HasColumnType("datetime");

                entity.Property(e => e.Direction)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdQuoteSaas)
                    .HasMaxLength(255)
                    .HasColumnName("IdQuoteSAAS");

                entity.Property(e => e.IdQuoteYat)
                    .HasMaxLength(255)
                    .HasColumnName("IdQuoteYAT");

                entity.Property(e => e.LinearFeet).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Miles).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotalCargoValue).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.User)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Weight).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.IdCustomerNavigation)
                    .WithMany(p => p.Quotes)
                    .HasForeignKey(d => d.IdCustomer)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Quotes_FK_Customer");

                entity.HasOne(d => d.IdModeGroupNavigation)
                    .WithMany(p => p.Quotes)
                    .HasForeignKey(d => d.IdModeGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Quotes_FK_ModeGroup");

                entity.HasOne(d => d.IdTypeTruckNavigation)
                    .WithMany(p => p.Quotes)
                    .HasForeignKey(d => d.IdTypeTruck)
                    .HasConstraintName("Quotes_FK_TypeTruck");

                entity.HasOne(d => d.IdUnitNavigation)
                    .WithMany(p => p.Quotes)
                    .HasForeignKey(d => d.IdUnit)
                    .HasConstraintName("Quotes_FK_Unit");

                entity.HasOne(d => d.IdZipCodeFromNavigation)
                    .WithMany(p => p.QuoteIdZipCodeFromNavigations)
                    .HasForeignKey(d => d.IdZipCodeFrom)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Quotes_FK_ZipcodeFrom");

                entity.HasOne(d => d.IdZipCodeToNavigation)
                    .WithMany(p => p.QuoteIdZipCodeToNavigations)
                    .HasForeignKey(d => d.IdZipCodeTo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Quotes_FK_ZipcodeTo");
            });

            modelBuilder.Entity<QuotesTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Quotes_Tmp");

                entity.Property(e => e.CityFrom).HasMaxLength(255);

                entity.Property(e => e.CityTo).HasMaxLength(255);

                entity.Property(e => e.DateQuote).HasColumnType("date");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IdQuoteSaas)
                    .HasMaxLength(255)
                    .HasColumnName("IdQuoteSAAS");

                entity.Property(e => e.IdQuoteYat)
                    .HasMaxLength(255)
                    .HasColumnName("IdQuoteYAT");

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotalCargoValue).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.User)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Weight).HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<RatesPerQuote>(entity =>
            {
                entity.ToTable("RatesPerQuote");

                entity.Property(e => e.CargoInsurance).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CarrierAccessorialCost).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CarrierAllInPlusAccessorialRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CarrierAllInRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CarrierFuelRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CarrierHighAllInRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CarrierHighLinehaulRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CarrierHighPmAllInRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CarrierHighPmLinehaulRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CarrierLinehaulRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CarrierLowAllInRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CarrierLowLinehaulRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CarrierLowPmAllInRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CarrierLowPmLinehaulRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CarrierPmAllInRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CarrierPmFuelRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CarrierPmLinehaulRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CustomerAccessorialCost).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CustomerAllInPlusAccessorialRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CustomerAllInRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CustomerFuelRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CustomerHighAllInRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CustomerHighLinehaulRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CustomerHighPmAllInRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CustomerHighPmLinehaulRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CustomerLinehaulRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CustomerLowAllInRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CustomerLowLinehaulRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CustomerLowPmAllInRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CustomerLowPmLinehaulRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CustomerPmAllInRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CustomerPmFuelRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CustomerPmLinehaulRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DirectRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DirectRateCargoInsurance).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DirectRateEmpty).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DirectRateMinInsuredCost).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DirectRateNetPrice).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DirectRateOperation).HasMaxLength(100);

                entity.Property(e => e.DirectRateTt).HasMaxLength(100);

                entity.Property(e => e.ForPickupAfter).HasColumnType("datetime");

                entity.Property(e => e.ForPickupBy).HasColumnType("datetime");

                entity.Property(e => e.HighLeadTimeValue).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.LowLeadTimeValue).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MinInsuredCost).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.RateId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TransbordRate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TransbordRateCargoInsurance).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TransbordRateEmpty).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TransbordRateMinInsuredCost).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TransbordRateNetPrice).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TransbordRateOperation).HasMaxLength(100);

                entity.Property(e => e.TransbordRateTt).HasMaxLength(100);

                entity.HasOne(d => d.IdQuoteNavigation)
                    .WithMany(p => p.RatesPerQuotes)
                    .HasForeignKey(d => d.IdQuote)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RatesPerQuote_FK");
            });

            modelBuilder.Entity<RatesPerQuoteDrayage>(entity =>
            {
                entity.ToTable("RatesPerQuoteDrayage");

                entity.Property(e => e.CargoInsurance).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MinInsuredCost).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Rate)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RateId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TotalCost).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.IdQuoteNavigation)
                    .WithMany(p => p.RatesPerQuoteDrayages)
                    .HasForeignKey(d => d.IdQuote)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RatesPerQuoteDrayage_FK");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RolesByUser>(entity =>
            {
                entity.HasOne(d => d.IdRoleNavigation)
                    .WithMany(p => p.RolesByUsers)
                    .HasForeignKey(d => d.IdRole)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RolesByUsers_FK_Roles");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.RolesByUsers)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RolesByUsers_FK_Users");
            });

            modelBuilder.Entity<SalesKam>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_SalesKam_Id")
                    .IsClustered(false);

                entity.ToTable("SalesKam");

                entity.HasIndex(e => e.Id, "UK_SalesKam_CodeSalesKam")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.NameSalesKam).HasMaxLength(255);

                entity.Property(e => e.Phone).HasMaxLength(15);
            });

            modelBuilder.Entity<SalesRep>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_SalesRep_Id")
                    .IsClustered(false);

                entity.ToTable("SalesRep");

                entity.HasIndex(e => e.Id, "UK_SalesRep_CodeSalesRep")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.NameSalesRep).HasMaxLength(255);

                entity.Property(e => e.Phone).HasMaxLength(15);
            });

            modelBuilder.Entity<ServiceMode>(entity =>
            {
                entity.ToTable("ServiceMode");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ShipmentsPerQuote>(entity =>
            {
                entity.ToTable("ShipmentsPerQuote");

                entity.Property(e => e.Cft).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Class).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Cmb).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Density).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Height).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Length).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.MeasurementUnit).HasMaxLength(10);

                entity.Property(e => e.Pieces).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Stack).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Weight).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Width).HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.IdQuoteNavigation)
                    .WithMany(p => p.ShipmentsPerQuotes)
                    .HasForeignKey(d => d.IdQuote)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("ShipmentsPerQuote_FK_Quote");

                entity.HasOne(d => d.IdUnitNavigation)
                    .WithMany(p => p.ShipmentsPerQuotes)
                    .HasForeignKey(d => d.IdUnit)
                    .HasConstraintName("ShipmentsPerQuote_FK_Unit");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasIndex(e => e.Id, "KEY_States_StateCode")
                    .IsUnique();

                entity.HasIndex(e => e.StateCode, "KEY_States_StateCode2")
                    .IsUnique();

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.StateCode)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.HasOne(d => d.CountryCodeNavigation)
                    .WithMany(p => p.States)
                    .HasPrincipalKey(p => p.Iso2Code)
                    .HasForeignKey(d => d.CountryCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_States_CountryCode");
            });

            modelBuilder.Entity<Tier>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_Tier_CodeTier")
                    .IsClustered(false);

                entity.ToTable("Tier");

                entity.HasIndex(e => e.Id, "UK_Tier_CodeTier")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Tier1)
                    .HasMaxLength(50)
                    .HasColumnName("Tier");
            });

            modelBuilder.Entity<TypeTruck>(entity =>
            {
                entity.ToTable("TypeTruck");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceCodeYat)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdModeGroupNavigation)
                    .WithMany(p => p.TypeTrucks)
                    .HasForeignKey(d => d.IdModeGroup)
                    .HasConstraintName("TypeTruck_FK");
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.ToTable("Unit");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.User1, "Users_UN")
                    .IsUnique();

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FirstName).HasMaxLength(150);

                entity.Property(e => e.LastName).HasMaxLength(150);

                entity.Property(e => e.User1)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("User");
            });

            modelBuilder.Entity<UsersCopium>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Users_copia");

                entity.Property(e => e.FirstName).HasMaxLength(150);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.LastName).HasMaxLength(150);

                entity.Property(e => e.User)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<VConfigInsurance>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_ConfigInsurance");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Formula).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MaxValorCarga).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MinCostAsegurado).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MinValorCarga).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Porcentaje).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Tier).HasMaxLength(50);

                entity.Property(e => e.TipoMercancia)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ValorMaximoMinima).HasColumnType("decimal(38, 18)");

                entity.Property(e => e.ValorMinima).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<VCustomerBilling>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("V_CustomerBilling");

                entity.Property(e => e.Amount).HasColumnType("numeric(20, 6)");

                entity.Property(e => e.Bol)
                    .HasMaxLength(100)
                    .HasColumnName("Bol#");

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CompanyName).HasMaxLength(250);

                entity.Property(e => e.DocumentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.Future).HasColumnType("numeric(20, 6)");

                entity.Property(e => e.Invoice)
                    .HasMaxLength(100)
                    .HasColumnName("Invoice#");

                entity.Property(e => e.InvoiceStatus)
                    .HasMaxLength(750)
                    .HasColumnName("invoiceStatus");

                entity.Property(e => e.Issued).HasColumnType("date");

                entity.Property(e => e.NameCustomer).HasMaxLength(100);

                entity.Property(e => e.OverDays).HasColumnName("Over Days");

                entity.Property(e => e.Pending).HasColumnType("numeric(20, 6)");

                entity.Property(e => e.Reference2).HasMaxLength(250);

                entity.Property(e => e.ReferenceBol).HasMaxLength(750);

                entity.Property(e => e.Status)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e._121Days)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("121+ Days");

                entity.Property(e => e._130Days)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("1-30 Days");

                entity.Property(e => e._3160Days)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("31-60 Days");

                entity.Property(e => e._6190Days)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("61-90 Days");

                entity.Property(e => e._91120Days)
                    .HasColumnType("numeric(20, 6)")
                    .HasColumnName("91-120 Days");
            });

            modelBuilder.Entity<VCustomerReceivable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("V_CustomerReceivables");

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CreditAvailable)
                    .HasColumnType("numeric(38, 6)")
                    .HasColumnName("Credit Available");

                entity.Property(e => e.CreditLimit).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TotalReceivables)
                    .HasColumnType("numeric(38, 6)")
                    .HasColumnName("Total receivables");

                entity.Property(e => e.ValorNoDue)
                    .HasColumnType("numeric(38, 6)")
                    .HasColumnName("Valor no-due");

                entity.Property(e => e.ValorOverdue)
                    .HasColumnType("numeric(38, 6)")
                    .HasColumnName("Valor Overdue");
            });

            modelBuilder.Entity<VCustomerRep>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_CustomerRep");

                entity.Property(e => e.Address1).HasMaxLength(200);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CreditLimit).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Email).HasMaxLength(800);

                entity.Property(e => e.EmailRep)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NameCustomer).HasMaxLength(100);

                entity.Property(e => e.NameSalesRep)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Phone).HasMaxLength(15);
            });

            modelBuilder.Entity<VCustomerStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("V_CustomerStatus");

                entity.Property(e => e.AvgCostperMile).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.AvgCostperPound).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.AvgDistance)
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AvgLeadTime).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.AvgTicket)
                    .HasColumnType("numeric(38, 6)")
                    .HasColumnName("Avg Ticket");

                entity.Property(e => e.AvgWeight)
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Bol)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessUnit).HasMaxLength(10);

                entity.Property(e => e.Canceled).HasDefaultValueSql("((0))");

                entity.Property(e => e.Canceled1)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("%Canceled");

                entity.Property(e => e.CardCode).HasMaxLength(15);

                entity.Property(e => e.CardName).HasMaxLength(200);

                entity.Property(e => e.Cost)
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvoiceAccuracy)
                    .HasColumnType("numeric(18, 4)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Lane)
                    .HasMaxLength(11)
                    .HasColumnName("lane");

                entity.Property(e => e.LeadTime)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("leadTime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModeGroup).HasMaxLength(50);

                entity.Property(e => e.MonthName).HasMaxLength(30);

                entity.Property(e => e.OnTime).HasDefaultValueSql("((0))");

                entity.Property(e => e.OnTimeDelivery)
                    .HasColumnType("numeric(18, 4)")
                    .HasColumnName("%OnTimeDelivery");

                entity.Property(e => e.SrkDate)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("SRK_Date");

                entity.Property(e => e.TotalRevenue).HasColumnType("numeric(38, 6)");
            });

            modelBuilder.Entity<VDraft>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_Drafts");

                entity.Property(e => e.Bol).HasMaxLength(100);

                entity.Property(e => e.Carrier).HasMaxLength(100);

                entity.Property(e => e.DateOfQuote).HasColumnType("datetime");

                entity.Property(e => e.Destination).HasMaxLength(100);

                entity.Property(e => e.Origin).HasMaxLength(100);

                entity.Property(e => e.ServiceType).HasMaxLength(50);
            });

            modelBuilder.Entity<VDraftsAll>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_DraftsAll");

                entity.Property(e => e.AcceptedTC).HasColumnName("acceptedT&C");

                entity.Property(e => e.Accesorials).HasMaxLength(100);

                entity.Property(e => e.AccesorialsDelivery).HasMaxLength(100);

                entity.Property(e => e.AccessorialCharge)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("accessorialCharge");

                entity.Property(e => e.AccessorialCode)
                    .HasMaxLength(100)
                    .HasColumnName("accessorialCode");

                entity.Property(e => e.AccessorialCode1)
                    .HasMaxLength(100)
                    .HasColumnName("accessorial_code");

                entity.Property(e => e.AccessorialCost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("accessorial_cost");

                entity.Property(e => e.AccessorialDescription)
                    .HasMaxLength(100)
                    .HasColumnName("accessorialDescription");

                entity.Property(e => e.AccessorialName)
                    .HasMaxLength(100)
                    .HasColumnName("accessorial_name");

                entity.Property(e => e.AddreesType)
                    .HasMaxLength(50)
                    .HasColumnName("addreesType");

                entity.Property(e => e.AddreesTypeDelivery)
                    .HasMaxLength(50)
                    .HasColumnName("addreesTypeDelivery");

                entity.Property(e => e.AllInPlusAccessorialRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("all_in_plus_accessorial_rate");

                entity.Property(e => e.AllInRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("all_in_rate");

                entity.Property(e => e.BolSwanleap).HasMaxLength(100);

                entity.Property(e => e.CargoInsuran)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("cargoInsuran");

                entity.Property(e => e.CargoInsurance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("cargoInsurance");

                entity.Property(e => e.CargoInsuranceActive).HasColumnName("cargoInsuranceActive");

                entity.Property(e => e.CargoOwnerCountry).HasMaxLength(100);

                entity.Property(e => e.CarrierId).HasColumnName("carrierId");

                entity.Property(e => e.CityOffcie)
                    .HasMaxLength(50)
                    .HasColumnName("cityOffcie");

                entity.Property(e => e.CommodityClass)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("commodityClass");

                entity.Property(e => e.CommodityType).HasMaxLength(50);

                entity.Property(e => e.ContactName).HasMaxLength(100);

                entity.Property(e => e.ContactNameDelivery).HasMaxLength(100);

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .HasColumnName("country");

                entity.Property(e => e.CountryDelivery).HasMaxLength(50);

                entity.Property(e => e.CountryOffice)
                    .HasMaxLength(50)
                    .HasColumnName("countryOffice");

                entity.Property(e => e.DefaultRate)
                    .HasColumnType("decimal(38, 0)")
                    .HasColumnName("default_rate");

                entity.Property(e => e.DeliveryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("deliveryDate");

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .HasColumnName("description");

                entity.Property(e => e.DirectRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("direct_rate");

                entity.Property(e => e.DirectRateCargoInsurance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("direct_rate_cargo_insurance");

                entity.Property(e => e.DirectRateMinInsuredCost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("direct_rate_min_insured_cost");

                entity.Property(e => e.DirectRateNetPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("direct_rate_net_price");

                entity.Property(e => e.DirectRateOperation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direct_rate_operation");

                entity.Property(e => e.Discount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("discount");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EmailDelivery).HasMaxLength(50);

                entity.Property(e => e.EmailOffice).HasMaxLength(50);

                entity.Property(e => e.FinalDate)
                    .HasColumnType("datetime")
                    .HasColumnName("finalDate");

                entity.Property(e => e.FinalDateDelivery)
                    .HasColumnType("datetime")
                    .HasColumnName("finalDateDelivery");

                entity.Property(e => e.FinalTime)
                    .HasColumnType("time(3)")
                    .HasColumnName("finalTime");

                entity.Property(e => e.FinalTimeDelivery)
                    .HasColumnType("time(3)")
                    .HasColumnName("finalTimeDelivery");

                entity.Property(e => e.ForPickupAfter)
                    .HasColumnType("datetime")
                    .HasColumnName("for_pickup_after");

                entity.Property(e => e.ForPickupBy)
                    .HasColumnType("datetime")
                    .HasColumnName("for_pickup_by");

                entity.Property(e => e.FuelRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("fuel_rate");

                entity.Property(e => e.FuelSurcharge)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("fuelSurcharge");

                entity.Property(e => e.GrossCharge)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("grossCharge");

                entity.Property(e => e.HazmatClass)
                    .HasMaxLength(100)
                    .HasColumnName("hazmatClass");

                entity.Property(e => e.Height)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("height");

                entity.Property(e => e.InitialDate)
                    .HasColumnType("datetime")
                    .HasColumnName("initialDate");

                entity.Property(e => e.InitialDateDelivery)
                    .HasColumnType("datetime")
                    .HasColumnName("initialDateDelivery");

                entity.Property(e => e.InitialTime)
                    .HasColumnType("time(3)")
                    .HasColumnName("initialTime");

                entity.Property(e => e.InitialTimeDelivery)
                    .HasColumnType("time(3)")
                    .HasColumnName("initialTimeDelivery");

                entity.Property(e => e.InsureFreight).HasColumnName("insureFreight");

                entity.Property(e => e.InsuredCargoOwner).HasMaxLength(100);

                entity.Property(e => e.Length)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("length");

                entity.Property(e => e.LinehaulRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("linehaul_rate");

                entity.Property(e => e.LocationName)
                    .HasMaxLength(100)
                    .HasColumnName("locationName");

                entity.Property(e => e.LocationNameDelivery)
                    .HasMaxLength(100)
                    .HasColumnName("locationNameDelivery");

                entity.Property(e => e.LocationOffice)
                    .HasMaxLength(100)
                    .HasColumnName("locationOffice");

                entity.Property(e => e.MinInsuredCost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("minInsuredCost");

                entity.Property(e => e.MinInsuredCostQuote)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("minInsuredCostQuote");

                entity.Property(e => e.ModeGroup)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.NetCharge)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("netCharge");

                entity.Property(e => e.NetPricesAccessorialCharges)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("netPricesAccessorialCharges");

                entity.Property(e => e.NetPricesDiscount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("netPricesDiscount");

                entity.Property(e => e.NetPricesFuelSurcharge)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("netPricesFuelSurcharge");

                entity.Property(e => e.NetPricesGrossCharge)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("netPricesGrossCharge");

                entity.Property(e => e.NetPricesTotalShipmentCost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("netPricesTotalShipmentCost");

                entity.Property(e => e.NomberOffice).HasMaxLength(100);

                entity.Property(e => e.ParkingGroup)
                    .HasMaxLength(100)
                    .HasColumnName("parkingGroup");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.PhoneDelivery).HasMaxLength(50);

                entity.Property(e => e.PhoneOffice).HasMaxLength(50);

                entity.Property(e => e.Quantity)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("quantity");

                entity.Property(e => e.Rate)
                    .HasMaxLength(50)
                    .HasColumnName("rate");

                entity.Property(e => e.RateId)
                    .HasMaxLength(100)
                    .HasColumnName("rateId");

                entity.Property(e => e.Reference)
                    .HasMaxLength(100)
                    .HasColumnName("reference");

                entity.Property(e => e.ReferenceDelivery)
                    .HasMaxLength(100)
                    .HasColumnName("referenceDelivery");

                entity.Property(e => e.Scac)
                    .HasMaxLength(100)
                    .HasColumnName("scac");

                entity.Property(e => e.SelectedMexicoRate)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("selectedMexicoRate");

                entity.Property(e => e.ServiceLevelDescription)
                    .HasMaxLength(100)
                    .HasColumnName("serviceLevelDescription");

                entity.Property(e => e.SpecialInstructions).HasMaxLength(4000);

                entity.Property(e => e.SpecialIntruction).HasMaxLength(1000);

                entity.Property(e => e.SpecialIntructionDelivery).HasMaxLength(1000);

                entity.Property(e => e.StateOffice)
                    .HasMaxLength(50)
                    .HasColumnName("stateOffice");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Street).HasMaxLength(100);

                entity.Property(e => e.Street2).HasMaxLength(100);

                entity.Property(e => e.Street2Delivery).HasMaxLength(100);

                entity.Property(e => e.StreetDelivery).HasMaxLength(100);

                entity.Property(e => e.StreetOffice).HasMaxLength(100);

                entity.Property(e => e.StrikeAccessorialCost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("strike_accessorial_cost");

                entity.Property(e => e.StrikeAllInPlusAccessorialRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("strike_all_in_plus_accessorial_rate");

                entity.Property(e => e.StrikeAllInRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("strike_all_in_rate");

                entity.Property(e => e.StrikeFuelRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("strike_fuel_rate");

                entity.Property(e => e.StrikeLinehaulRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("strike_linehaul_rate");

                entity.Property(e => e.TotalCargoValue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TotalCost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalCost");

                entity.Property(e => e.TotalShipmentCost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalShipmentCost");

                entity.Property(e => e.TransbordRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("transbord_rate");

                entity.Property(e => e.TransbordRateCargoInsurance)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("transbord_rate_cargo_insurance");

                entity.Property(e => e.TransbordRateMinInsuredCost)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("transbord_rate_min_insured_cost");

                entity.Property(e => e.TransbordRateNetPrice)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("transbord_rate_net_price");

                entity.Property(e => e.TransbordRateOperation)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("transbord_rate_operation");

                entity.Property(e => e.TransitDays).HasColumnName("transitDays");

                entity.Property(e => e.UnNumber)
                    .HasMaxLength(100)
                    .HasColumnName("unNumber");

                entity.Property(e => e.Unit)
                    .HasMaxLength(20)
                    .HasColumnName("unit");

                entity.Property(e => e.WeightAccesorials).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WeightDraf).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Width)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("width");

                entity.Property(e => e.ZipCode).HasMaxLength(10);
            });

            modelBuilder.Entity<VInvoice>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("V_Invoice");

                entity.Property(e => e.AcctCode).HasMaxLength(15);

                entity.Property(e => e.ActualDeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.Address1).HasMaxLength(200);

                entity.Property(e => e.Bol)
                    .HasMaxLength(20)
                    .HasColumnName("BOL");

                entity.Property(e => e.CardCode).HasMaxLength(15);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Class).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.CodeCustomer).HasMaxLength(255);

                entity.Property(e => e.Comments).HasMaxLength(254);

                entity.Property(e => e.Commodities).IsUnicode(false);

                entity.Property(e => e.Controlled).HasMaxLength(100);

                entity.Property(e => e.CreatorUser)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreditTerms).HasMaxLength(50);

                entity.Property(e => e.Ctf).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.Customer).HasMaxLength(10);

                entity.Property(e => e.CustomerOffice).HasMaxLength(200);

                entity.Property(e => e.DaysOverdue).HasMaxLength(10);

                entity.Property(e => e.Density).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DestinationCity).HasMaxLength(500);

                entity.Property(e => e.DestinationCompany).HasMaxLength(50);

                entity.Property(e => e.DestinationCountry).HasMaxLength(50);

                entity.Property(e => e.DestinationName).HasMaxLength(500);

                entity.Property(e => e.DestinationStreet1).HasMaxLength(50);

                entity.Property(e => e.Distance).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.DocDate).HasColumnType("datetime");

                entity.Property(e => e.DocNum).HasMaxLength(25);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.Fax)
                    .HasMaxLength(15)
                    .HasColumnName("fax");

                entity.Property(e => e.Hazmat).HasMaxLength(10);

                entity.Property(e => e.Invoice)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("invoice");

                entity.Property(e => e.ItemCode).HasMaxLength(50);

                entity.Property(e => e.ItemName).HasMaxLength(100);

                entity.Property(e => e.ModeGroup).HasMaxLength(50);

                entity.Property(e => e.ModeGroupSap)
                    .HasMaxLength(50)
                    .HasColumnName("ModeGroupSAP");

                entity.Property(e => e.NameCustomer).HasMaxLength(100);

                entity.Property(e => e.ObjType).HasMaxLength(20);

                entity.Property(e => e.OriginCity).HasMaxLength(500);

                entity.Property(e => e.OriginCompany).HasMaxLength(50);

                entity.Property(e => e.OriginCountry).HasMaxLength(50);

                entity.Property(e => e.OriginEmail).HasMaxLength(50);

                entity.Property(e => e.OriginName).HasMaxLength(500);

                entity.Property(e => e.OriginPhone).HasMaxLength(50);

                entity.Property(e => e.OriginStreet1).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(15);

                entity.Property(e => e.Pieces).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.PiecesDetail).IsUnicode(false);

                entity.Property(e => e.PriceItem).HasColumnType("numeric(21, 6)");

                entity.Property(e => e.Quantity).HasColumnType("numeric(21, 6)");

                entity.Property(e => e.ReferenceBol).HasMaxLength(750);

                entity.Property(e => e.SellPrice).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Service).HasMaxLength(150);

                entity.Property(e => e.ShipmentStatus).HasMaxLength(150);

                entity.Property(e => e.State).HasMaxLength(20);

                entity.Property(e => e.TotalRevenue).HasColumnType("numeric(21, 6)");

                entity.Property(e => e.TotalWeight).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.TypeInvoive)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Vendor)
                    .HasMaxLength(150)
                    .HasColumnName("vendor");

                entity.Property(e => e.ZipCode).HasMaxLength(10);

                entity.Property(e => e.ZipcodeDestino).HasMaxLength(50);

                entity.Property(e => e.ZipcodeOrigen).HasMaxLength(50);
            });

            modelBuilder.Entity<VQuoteHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("V_QuoteHistory");

                entity.Property(e => e.DateOfQoute).HasColumnType("date");

                entity.Property(e => e.Destination)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Origin)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.ToTable("Vendor");

                entity.Property(e => e.Address1).HasMaxLength(250);

                entity.Property(e => e.Address2).HasMaxLength(250);

                entity.Property(e => e.CarrierLiability).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Cfs).HasColumnName("CFS");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.Company).HasMaxLength(50);

                entity.Property(e => e.Contact).HasMaxLength(100);

                entity.Property(e => e.Country).HasMaxLength(10);

                entity.Property(e => e.Details)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Fax).HasMaxLength(10);

                entity.Property(e => e.Image).HasMaxLength(250);

                entity.Property(e => e.Mc).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.PaymentMetod).HasMaxLength(50);

                entity.Property(e => e.Payto).HasMaxLength(100);

                entity.Property(e => e.PaytoAddress).HasMaxLength(100);

                entity.Property(e => e.PaytoCity).HasMaxLength(50);

                entity.Property(e => e.PaytoCountry)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.PaytoZipcode).HasMaxLength(10);

                entity.Property(e => e.Phone).HasMaxLength(20);

                entity.Property(e => e.ProviderNameSaas)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderNameSwanleap)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderScacSaas)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderScacSwanleap).HasMaxLength(100);

                entity.Property(e => e.ServiceScore).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Services).HasMaxLength(10);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.Tsa).HasColumnName("TSA");

                entity.Property(e => e.ValidityRate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VendorGroup).HasMaxLength(100);

                entity.Property(e => e.ZipCode).HasMaxLength(10);
            });

            modelBuilder.Entity<ZipCode>(entity =>
            {
                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DaylightSaving).HasMaxLength(2);

                entity.Property(e => e.FullZipCode).HasMaxLength(100);

                entity.Property(e => e.TimeZone).HasMaxLength(5);

                entity.Property(e => e.ZipCode1)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("ZipCode");

                entity.HasOne(d => d.IdStateNavigation)
                    .WithMany(p => p.ZipCodes)
                    .HasForeignKey(d => d.IdState)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ZipCodes_States");
            });

            modelBuilder.Entity<ZipCodesTmp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ZipCodes_tmp");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.CountryCode)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.DaylightSaving).HasMaxLength(2);

                entity.Property(e => e.FullZipCode).HasMaxLength(100);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.StateCode)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.TimeZone).HasMaxLength(5);

                entity.Property(e => e.ZipCode)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Zipcodecanadum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("zipcodecanada");

                entity.Property(e => e.City).HasMaxLength(255);

                entity.Property(e => e.Estado).HasMaxLength(255);

                entity.Property(e => e.FullZipCode).HasMaxLength(255);

                entity.Property(e => e.IdState).HasMaxLength(255);

                entity.Property(e => e.ZipCode).HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
