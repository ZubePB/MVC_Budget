using Budget.DataModels.BusinessModels;
using Microsoft.EntityFrameworkCore;

namespace Budget.Database;

public class BusinessTransactionContext : DbContext
{
    public DbSet<BusinessTransaction> Transactions { get; set; }
    
    public DbSet<BusinessCategory> Categories { get; set; }

    public DbSet<BusinessSupplier> Suppliers { get; set; }

    public BusinessTransactionContext(DbContextOptions<BusinessTransactionContext> options) : base(options) => CreateDb();

    private void CreateDb()
    {
        // only change for migration purpose or database reset
        if (false)
        {
            try
            {
                Database.EnsureDeleted();
            }
            catch { }
            Database.EnsureCreated();
        }
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        optionsBuilder.UseSqlServer(configuration.GetConnectionString("BusinessConnectionString"));

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BusinessTransaction>().HasKey(x => new { x.Id });
        modelBuilder.Entity<BusinessCategory>().HasKey(x => new { x.Id });
        modelBuilder.Entity<BusinessSupplier>().HasKey(x => new { x.Id });

        modelBuilder.Entity<BusinessTransaction>().HasOne(x => x.Category).WithMany(x => x.Transactions);
        modelBuilder.Entity<BusinessTransaction>().HasIndex(x => x.CategoryId);

        modelBuilder.Entity<BusinessTransaction>().HasOne(x => x.Supplier).WithMany(x => x.Transactions);
        modelBuilder.Entity<BusinessTransaction>().HasIndex(x => x.SupplierId);

        modelBuilder.Entity<BusinessCategory>().HasMany(x => x.Transactions).WithOne(x => x.Category).HasForeignKey(x => x.CategoryId);
        modelBuilder.Entity<BusinessSupplier>().HasMany(x => x.Transactions).WithOne(x => x.Supplier).HasForeignKey(x => x.SupplierId);
        
        modelBuilder.Entity<BusinessCategory>().Ignore(x => x.Transactions);
        modelBuilder.Entity<BusinessSupplier>().Ignore(x => x.Transactions);

        modelBuilder.Entity<BusinessCategory>().Property(x => x.TotalAmount).UsePropertyAccessMode(PropertyAccessMode.Property);
        modelBuilder.Entity<BusinessCategory>().Property(x => x.NumberOfTransaction).UsePropertyAccessMode(PropertyAccessMode.Property);

        modelBuilder.Entity<BusinessSupplier>().Property(x => x.TotalAmount).UsePropertyAccessMode(PropertyAccessMode.Property);
        modelBuilder.Entity<BusinessSupplier>().Property(x => x.NumberOfTransaction).UsePropertyAccessMode(PropertyAccessMode.Property);

        // only use for migration or data seeding
        if (false)
        {
            using (DataSeed ds = new())
            {
                List<BusinessCategory> categories = ds.SeedBusinessCategories();
                List<BusinessTransaction> transactions = ds.SeedBusinessTransactions(categories);
                List<BusinessSupplier> suppliers = ds.SeedBusinessSuppliers(transactions);
                transactions = ds.GetBusinessSupplierIds(transactions,suppliers);
                foreach(BusinessCategory cat in categories)
                {
                    cat.Transactions = transactions.Where(x => x.CategoryId == cat.Id).ToList();
                }

                modelBuilder.Entity<BusinessTransaction>().HasData(transactions);
                modelBuilder.Entity<BusinessCategory>().HasData(categories);
                modelBuilder.Entity<BusinessSupplier>().HasData(suppliers);
            }
        }

        base.OnModelCreating(modelBuilder);
    }

}