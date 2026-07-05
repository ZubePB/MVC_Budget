using Budget.DataModels.PersonalModels;
using Microsoft.EntityFrameworkCore;

namespace Budget.Database;

public class PersonalTransactionContext : DbContext
{
    public DbSet<PersonalTransaction> Transactions { get; set; }

    public DbSet<PersonalCategory> Categories { get; set; }

    public PersonalTransactionContext(DbContextOptions<PersonalTransactionContext> options) : base(options) => CreateDb();

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

        optionsBuilder.UseSqlServer(configuration.GetConnectionString("PersonalConnectionString"));

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PersonalTransaction>().HasKey(x => new { x.Id });
        modelBuilder.Entity<PersonalCategory>().HasKey(x => new { x.Id });

        modelBuilder.Entity<PersonalTransaction>().HasOne(x => x.Category).WithMany(x => x.Transactions);
        modelBuilder.Entity<PersonalTransaction>().HasIndex(x => x.CategoryId);

        modelBuilder.Entity<PersonalCategory>().HasMany(x => x.Transactions).WithOne(x => x.Category).HasForeignKey(x => x.CategoryId);

        modelBuilder.Entity<PersonalCategory>().Ignore(x => x.Transactions);

        modelBuilder.Entity<PersonalCategory>().Property(x => x.TotalAmount).UsePropertyAccessMode(PropertyAccessMode.Property);
        modelBuilder.Entity<PersonalCategory>().Property(x => x.NumberOfTransaction).UsePropertyAccessMode(PropertyAccessMode.Property);

        // only use for migration or data seeding
        if (false)
        {
            using (DataSeed ds = new())
            {
                List<PersonalCategory> categories = ds.SeedPersonalCategories();
                List<PersonalTransaction> transactions = ds.SeedPersonalTransactions(categories);
                foreach (PersonalCategory cat in categories)
                {
                    cat.Transactions = transactions.Where(x => x.CategoryId == cat.Id).ToList();
                }

                modelBuilder.Entity<PersonalTransaction>().HasData(transactions);
                modelBuilder.Entity<PersonalCategory>().HasData(categories);
            }
        }

        base.OnModelCreating(modelBuilder);
    }

}