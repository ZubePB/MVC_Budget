using Budget.Database;
using Budget.DataModels.BusinessModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Budget.Controllers;

public class BusinessSupplierController : Controller
{
    private readonly BusinessTransactionContext _context;

    public BusinessSupplierController(BusinessTransactionContext context) => _context = context;

    public async Task<IResult> GetAll() => TypedResults.Ok(await _context.Suppliers.ToListAsync());

    public async Task<IResult> Get(int id) => await _context.Suppliers.FindAsync(id) is BusinessSupplier supplier ? TypedResults.Ok(supplier) : TypedResults.NotFound();

    public async Task<IResult> Create([FromBody]BusinessSupplier supplier)
    {
        _context.Suppliers.Add(supplier);
        await _context.SaveChangesAsync();

        return TypedResults.NoContent();
    }

    public async Task<IResult> Edit([FromBody]BusinessSupplier inputSupplier, int id)
    {
        BusinessSupplier? supplier = await _context.Suppliers.FindAsync(id);

        if (supplier == null) return TypedResults.NotFound();

        supplier.Name = inputSupplier.Name;

        await _context.SaveChangesAsync();

        return TypedResults.NoContent();
    }

    public async Task<IResult> Delete(int id)
    {
        BusinessSupplier? supplier = await _context.Suppliers.FindAsync(id);

        if (supplier == null) return TypedResults.NotFound();

        _context.Remove(supplier);

        await _context.SaveChangesAsync();

        foreach (BusinessCategory cat in _context.Categories) cat.Transactions = await _context.Transactions.Where(x => x.CategoryId == cat.Id).ToListAsync();

        await _context.SaveChangesAsync();

        return TypedResults.NoContent();
    }
}