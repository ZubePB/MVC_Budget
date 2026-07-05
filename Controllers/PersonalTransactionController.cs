using Budget.Database;
using Budget.DataModels.PersonalModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Budget.Controllers;

public class PersonalTransactionController : Controller
{
    private readonly PersonalTransactionContext _context;

    public PersonalTransactionController(PersonalTransactionContext context) => _context = context;

    public async Task<IResult> GetAll(bool dateBox, string? dateMode, DateTime? date, bool amountBox, string? amountMode, double? amount, int? categoryId, string? name)
    {
        List<PersonalTransaction> transactions = await _context.Transactions.ToListAsync();

        if (dateBox && date != null && date.Value.Date > DateTime.MinValue.Date)
        {
            if (dateMode == "more") transactions = transactions.Where(x => x.Date.Date >= date.Value.Date).ToList();
            else transactions = transactions.Where(x => x.Date.Date <= date.Value.Date).ToList();
        }

        if (amountBox && amount != null && amount > 0)
        {
            if (amountMode == "more") transactions = transactions.Where(x => x.Amount >= amount).ToList();
            else transactions = transactions.Where(x => x.Amount <= amount).ToList();
        }

        if (categoryId != null && await PersonalCategoryExists((int)categoryId)) transactions = transactions.Where(x => x.CategoryId == categoryId).ToList();

        if (!string.IsNullOrEmpty(name))
        {
            name = name.ToLower();
            transactions = transactions.Where(x => x.Name!.ToLower().Contains(name)).ToList();
        }

        return Results.Ok(transactions);
    }

    public async Task<IResult> Get(int id) => await _context.Transactions.FindAsync(id) is PersonalTransaction transaction ? TypedResults.Ok(transaction) : TypedResults.NotFound();

    public async Task<IResult> Create([FromBody] PersonalTransaction transaction)
    {
        PersonalCategory? category = await _context.Categories.FindAsync(transaction.CategoryId);

        if (category == null) return TypedResults.NotFound();

        _context.Transactions.Add(transaction);

        await _context.SaveChangesAsync();

        category.Transactions = await _context.Transactions.Where(x => x.CategoryId == category.Id).ToListAsync();

        await _context.SaveChangesAsync();

        return TypedResults.Created($"/transactions/{transaction.Id}", transaction);
    }

    public async Task<IResult> Edit([FromBody] PersonalTransaction inputTransaction, int id)
    {
        PersonalTransaction? transaction = await _context.Transactions.FindAsync(id);

        if (transaction == null) return TypedResults.NotFound();

        PersonalCategory? category = await _context.Categories.FindAsync(transaction.CategoryId);
        PersonalCategory? inputCategory = await _context.Categories.FindAsync(inputTransaction.CategoryId);

        if (inputCategory == null) return TypedResults.NotFound();

        transaction.Name = inputTransaction.Name;
        transaction.Date = inputTransaction.Date;
        transaction.CategoryId = inputTransaction.CategoryId;
        transaction.Amount = inputTransaction.Amount;

        await _context.SaveChangesAsync();

        if (category!.Id != inputCategory.Id)
        {
            inputCategory.Transactions = await _context.Transactions.Where(x => x.CategoryId == inputCategory.Id).ToListAsync();

            category.Transactions = await _context.Transactions.Where(x => x.CategoryId == category.Id).ToListAsync();

            await _context.SaveChangesAsync();
        }

        return TypedResults.NoContent();
    }

    public async Task<IResult> Patch([FromBody] PersonalTransaction inputTransaction, int id)
    {
        PersonalTransaction? transaction = await _context.Transactions.FindAsync(id);

        if (transaction == null) return TypedResults.NotFound();

        if (!string.IsNullOrEmpty(inputTransaction.Name)) transaction.Name = inputTransaction.Name;
        if (await PersonalCategoryExists(inputTransaction.CategoryId)) transaction.CategoryId = inputTransaction.CategoryId;
        if (inputTransaction.Date != DateTime.MinValue) transaction.Date = inputTransaction.Date;
        if (inputTransaction.Amount > 0 && inputTransaction.Amount <= 5000) transaction.Amount = inputTransaction.Amount;
        await _context.SaveChangesAsync();

        return TypedResults.NoContent();
    }

    public async Task<IResult> Delete(int id)
    {
        PersonalTransaction? transaction = await _context.Transactions.FindAsync(id);

        if (transaction == null) return TypedResults.NotFound();

        PersonalCategory? category = await _context.Categories.FindAsync(transaction.CategoryId);

        if (category == null) return TypedResults.NotFound();

        _context.Transactions.Remove(transaction);
        await _context.SaveChangesAsync();

        category.Transactions = await _context.Transactions.Where(x => x.CategoryId == category.Id).ToListAsync();

        await _context.SaveChangesAsync();

        return TypedResults.NoContent();
    }

    private async Task<bool> PersonalCategoryExists(int id) => await _context.Categories.AnyAsync(x => x.Id == id);
}