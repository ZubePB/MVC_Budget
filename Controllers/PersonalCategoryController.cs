using Budget.Database;
using Budget.DataModels.PersonalModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Budget.Controllers;

public class PersonalCategoryController : Controller
{
    private readonly PersonalTransactionContext _context;

    public PersonalCategoryController(PersonalTransactionContext context) => _context = context;

    public async Task<IResult> GetAll() => TypedResults.Ok(await _context.Categories.ToListAsync());

    public async Task<IResult> Get(int id)
    {
        PersonalCategory? category = await _context.Categories.FindAsync(id);

        if (category == null) return TypedResults.NotFound();

        return TypedResults.Ok(category);
    }

    public async Task<IResult> Create([FromBody]PersonalCategory category)
    {
        _context.Categories.Add(category);
        await _context.SaveChangesAsync();

        return TypedResults.Created($"/categories/{category.Id}", category);
    }

    public async Task<IResult> Edit([FromBody]PersonalCategory inputCategory, int id)
    {
        PersonalCategory? category = await _context.Categories.FindAsync(id);

        if (category == null) return TypedResults.NotFound();

        category.Name = inputCategory.Name;

        await _context.SaveChangesAsync();

        return TypedResults.NoContent();
    }

    public async Task<IResult> Delete(int id)
    {
        PersonalCategory? category = await _context.Categories.FindAsync(id);

        if (category == null) return TypedResults.NotFound();

        _context.Remove(category);

        await _context.SaveChangesAsync();

        return TypedResults.NoContent();
    }

    public async Task<IResult> Patch([FromBody] PersonalCategory inputCategory, int id)
    {
        PersonalCategory? category = await _context.Categories.FindAsync(id);

        if (category == null) return TypedResults.NotFound();

        if (!string.IsNullOrEmpty(inputCategory.Name)) category.Name = inputCategory.Name;

        await _context.SaveChangesAsync();

        return TypedResults.NoContent();
    }
}