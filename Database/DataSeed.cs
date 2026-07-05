using Budget.DataModels.BusinessModels;
using Budget.DataModels.PersonalModels;

namespace Budget.Database;

public class DataSeed : IDisposable
{
    public void Dispose()
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }

    public DataSeed() { }

    internal List<BusinessTransaction> SeedBusinessTransactions(List<BusinessCategory> categories)
    {
        List<BusinessTransaction> transactions = [];
        DateTime dt = DateTime.Now;
        Random rng = new();

        for (int i = 1; i < 1001; i++)
        {
            BusinessCategory category = categories[i % 10];
            double amount = (double)rng.Next(100, 2000) / rng.Next(20, 100);
            amount = Math.Round(amount, 2);
            transactions.Add(new()
            {
                Id = i,
                Name = $"{category.Name}_{i / 10}",
                Date = dt,
                CategoryId = category.Id,
                Amount = amount,
            });

            dt = dt.AddDays(rng.Next(0, 2));
        }

        return transactions;
    }

    internal List<BusinessCategory> SeedBusinessCategories()
    {
        return new()
        {
            new BusinessCategory() {Id = 1, Name = "Wood" },
            new BusinessCategory() {Id = 2, Name = "Aluminium" },
            new BusinessCategory() {Id = 3, Name = "Iron" },
            new BusinessCategory() {Id = 4, Name = "Stainless Steel" },
            new BusinessCategory() {Id = 5, Name = "Screws" },
            new BusinessCategory() {Id = 6, Name = "Wood Tools" },
            new BusinessCategory() {Id = 7, Name = "Door Accessories" },
            new BusinessCategory() {Id = 8, Name = "Glass" },
            new BusinessCategory() {Id = 9, Name = "Metal Tools" },
            new BusinessCategory() {Id = 10, Name = "Glass Accessories" },
        };
    }

    internal List<BusinessSupplier> SeedBusinessSuppliers(List<BusinessTransaction> transactions)
    {
        return new()
        {
            new() {Id = 1, Name = "Glasson", Transactions = transactions.Where(x => x.CategoryId == 2 || x.CategoryId == 3 || x.CategoryId == 4).ToList() },
            new() {Id = 2, Name = "Bauhaus", Transactions = transactions.Where(x => x.CategoryId == 6 || x.CategoryId == 9).ToList() },
            new() {Id = 3, Name = "Scierie de Romont", Transactions = transactions.Where(x => x.CategoryId == 1).ToList() },
            new() {Id = 4, Name = "Sofraver SA", Transactions = transactions.Where(x => x.CategoryId == 8 || x.CategoryId == 10).ToList() },
            new() {Id = 5, Name = "Commerce de Fer Fribourgeois", Transactions = transactions.Where(x => x.CategoryId == 5 || x.CategoryId == 7).ToList()}
        };
    }

    internal List<BusinessTransaction> GetBusinessSupplierIds(List<BusinessTransaction> transactions, List<BusinessSupplier> suppliers)
    {
        foreach (BusinessTransaction t in transactions) t.SupplierId = suppliers.First(x => x.Transactions!.Any(x => x.Id == t.Id)).Id;
        return transactions;
    }

    internal List<PersonalTransaction> SeedPersonalTransactions(List<PersonalCategory> categories)
    {
        List<PersonalTransaction> transactions = [];
        DateTime dt = DateTime.Now;
        Random rng = new();

        for (int i = 1; i < 1001; i++)
        {
            PersonalCategory category = categories[i % 10];
            double amount = (double)rng.Next(100, 2000) / rng.Next(20, 100);
            amount = Math.Round(amount, 2);
            transactions.Add(new()
            {
                Id = i,
                Name = $"{category.Name}_{i / 10}",
                Date = dt,
                CategoryId = category.Id,
                Amount = amount,
            });

            dt = dt.AddDays(rng.Next(0, 2));
        }

        return transactions;
    }

    internal List<PersonalCategory> SeedPersonalCategories()
    {
        return new()
        {
            new PersonalCategory() {Id = 1, Name = "Electricity" },
            new PersonalCategory() {Id = 2, Name = "Water" },
            new PersonalCategory() {Id = 3, Name = "Gaz" },
            new PersonalCategory() {Id = 4, Name = "Food" },
            new PersonalCategory() {Id = 5, Name = "Cat Food" },
            new PersonalCategory() {Id = 6, Name = "TV" },
            new PersonalCategory() {Id = 7, Name = "Phones Bills" },
            new PersonalCategory() {Id = 8, Name = "Hobbies" },
            new PersonalCategory() {Id = 9, Name = "Economies" },
            new PersonalCategory() {Id = 10, Name = "Medication" },
        };
    }
}