using Budget.Database;
using Budget.DataModels.BusinessModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Budget.Controllers;

public class BusinessCategoryController : Controller
{
    private readonly BusinessTransactionContext _context;

    public BusinessCategoryController(BusinessTransactionContext context) => _context = context;

    public async Task<IResult> GetAll()
    {
        List<BusinessCategory> categories = await _context.Categories.ToListAsync();
        return TypedResults.Ok(categories);
    }

    public async Task<IResult> Get(int id)
    {
        BusinessCategory? category = await _context.Categories.FindAsync(id);

        if (category == null) return TypedResults.NotFound();

        return TypedResults.Ok(category);
    }

    public async Task<IResult> Create([FromBody] BusinessCategory category)
    {
        _context.Categories.Add(category);
        await _context.SaveChangesAsync();

        return TypedResults.Created($"/categories/{category.Id}", category);
    }

    public async Task<IResult> Edit([FromBody] BusinessCategory inputCategory, int id)
    {
        BusinessCategory? category = await _context.Categories.FindAsync(id);

        if (category == null) return TypedResults.NotFound();

        category.Name = inputCategory.Name;

        await _context.SaveChangesAsync();

        return TypedResults.NoContent();
    }

    public async Task<IResult> Delete(int id)
    {
        BusinessCategory? category = await _context.Categories.FindAsync(id);

        if (category == null) return TypedResults.NotFound();


        _context.Remove(category);

        await _context.SaveChangesAsync();

        foreach (BusinessSupplier supplier in _context.Suppliers) supplier.Transactions = await _context.Transactions.Where(x => x.SupplierId == supplier.Id).ToListAsync();

        await _context.SaveChangesAsync();

        return TypedResults.NoContent();
    }

    public async Task<IResult> Patch([FromBody] BusinessCategory inputCategory, int id)
    {
        BusinessCategory? category = await _context.Categories.FindAsync(id);

        if (category == null) return TypedResults.NotFound();

        if (!string.IsNullOrEmpty(inputCategory.Name)) category.Name = inputCategory.Name;

        await _context.SaveChangesAsync();

        return TypedResults.NoContent();
    }
}