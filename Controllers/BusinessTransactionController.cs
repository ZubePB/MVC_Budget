using Budget.Database;
using Budget.DataModels;
using Budget.DataModels.BusinessModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Quartz;
using Quartz.Impl.Matchers;
using Quartz.Util;

namespace Budget.Controllers;

public class BusinessTransactionController : Controller
{
    private readonly BusinessTransactionContext _context;
    private readonly ISchedulerFactory _quartzScheduler;

    public BusinessTransactionController(BusinessTransactionContext context, ISchedulerFactory scheduler)
    {
        _context = context;
        _quartzScheduler = scheduler;
    }

    public async Task<IResult> GetAll(bool dateBox, string? dateMode, DateTime? date, bool amountBox, string? amountMode, double? amount, int? categoryId, int? supplierId, string? name, int recurrent)
    {
        List<BusinessTransaction> transactions = await _context.Transactions.ToListAsync();

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

        if (categoryId != null && await BusinessCategoryExists((int)categoryId)) transactions = transactions.Where(x => x.CategoryId == categoryId).ToList();
        if (supplierId != null && await BusinessSupplierExists((int)supplierId)) transactions = transactions.Where(x => x.SupplierId == supplierId).ToList();

        if (!string.IsNullOrEmpty(name))
        {
            name = name.ToLower();
            transactions = transactions.Where(x => x.Name!.ToLower().Contains(name)).ToList();
        }
        
        if(recurrent == 1 || recurrent == 2)
        {
            bool rec = recurrent == 1 ? false : true;
            transactions = transactions.Where(x => x.Recurrent == rec).ToList();
        }

        return Results.Ok(transactions);
    }

    public async Task<IResult> Get(int id) => await _context.Transactions.FindAsync(id) is BusinessTransaction transaction ? TypedResults.Ok(transaction) : TypedResults.NotFound();

    public async Task<IResult> Create([FromBody] BusinessTransaction transaction)
    {
        BusinessCategory? category = await _context.Categories.FindAsync(transaction.CategoryId);

        if (category == null) return TypedResults.NotFound();

        BusinessSupplier? supplier = await _context.Suppliers.FindAsync(transaction.SupplierId);

        if (supplier == null) return TypedResults.NotFound();

        transaction.Recurrent = false;
        _context.Transactions.Add(transaction);

        await _context.SaveChangesAsync();

        category.Transactions = await _context.Transactions.Where(x => x.CategoryId == category.Id).ToListAsync();
        supplier.Transactions = await _context.Transactions.Where(x => x.SupplierId == supplier.Id).ToListAsync();

        await _context.SaveChangesAsync();

        return TypedResults.Created($"/transactions/{transaction.Id}", transaction);
    }

    public async Task<IResult> Edit([FromBody] BusinessTransaction inputTransaction, int id)
    {
        BusinessTransaction? transaction = await _context.Transactions.FindAsync(id);

        if (transaction == null) return TypedResults.NotFound();

        BusinessCategory? category = await _context.Categories.FindAsync(transaction.CategoryId);
        BusinessCategory? inputCategory = await _context.Categories.FindAsync(inputTransaction.CategoryId);

        if (inputCategory == null) return TypedResults.NotFound();

        BusinessSupplier? supplier = await _context.Suppliers.FindAsync(transaction.SupplierId);
        BusinessSupplier? inputSupplier = await _context.Suppliers.FindAsync(inputTransaction.SupplierId);

        if (inputSupplier == null) return TypedResults.NotFound();

        transaction.Name = inputTransaction.Name;
        transaction.Date = inputTransaction.Date;
        transaction.CategoryId = inputTransaction.CategoryId;
        transaction.Amount = inputTransaction.Amount;
        transaction.SupplierId = inputTransaction.SupplierId;

        await _context.SaveChangesAsync();

        inputCategory.Transactions = await _context.Transactions.Where(x => x.CategoryId == inputCategory.Id).ToListAsync();

        if (category!.Id != inputCategory.Id) category.Transactions = await _context.Transactions.Where(x => x.CategoryId == category.Id).ToListAsync();

        inputSupplier.Transactions = await _context.Transactions.Where(x => x.SupplierId == inputSupplier.Id).ToListAsync();

        if (supplier!.Id != inputSupplier.Id) supplier.Transactions = await _context.Transactions.Where(x => x.SupplierId == supplier.Id).ToListAsync();

        await _context.SaveChangesAsync();

        return TypedResults.NoContent();
    }

    public async Task<IResult> Patch(BusinessTransaction inputTransaction, int id)
    {
        BusinessTransaction? transaction = await _context.Transactions.FindAsync(id);

        if (transaction == null) return TypedResults.NotFound();

        if (!string.IsNullOrEmpty(inputTransaction.Name)) transaction.Name = inputTransaction.Name;
        if (await BusinessCategoryExists(inputTransaction.CategoryId)) transaction.CategoryId = inputTransaction.CategoryId;
        if (inputTransaction.Date != DateTime.MinValue) transaction.Date = inputTransaction.Date;
        if (inputTransaction.Amount > 0 && inputTransaction.Amount <= 5000) transaction.Amount = inputTransaction.Amount;
        await _context.SaveChangesAsync();

        return TypedResults.NoContent();
    }

    public async Task<IResult> Delete(int id)
    {
        BusinessTransaction? transaction = await _context.Transactions.FindAsync(id);

        if (transaction == null) return TypedResults.NotFound();

        BusinessCategory? category = await _context.Categories.FindAsync(transaction.CategoryId);

        if (category == null) return TypedResults.NotFound();

        BusinessSupplier? supplier = await _context.Suppliers.FindAsync(transaction.SupplierId);

        if (supplier == null) return TypedResults.NotFound();

        _context.Transactions.Remove(transaction);
        await _context.SaveChangesAsync();

        category.Transactions = await _context.Transactions.Where(x => x.CategoryId == category.Id).ToListAsync();
        supplier.Transactions = await _context.Transactions.Where(x => x.SupplierId == supplier.Id).ToListAsync();

        await _context.SaveChangesAsync();

        return TypedResults.NoContent();
    }

    private async Task<bool> BusinessCategoryExists(int id) => await _context.Categories.AnyAsync(x => x.Id == id);
    private async Task<bool> BusinessSupplierExists(int id) => await _context.Suppliers.AnyAsync(x => x.Id == id);

    public async void AddAuto([FromBody] BusinessTransaction transaction, int? interval)
    {
        IScheduler scheduler = await _quartzScheduler.GetScheduler();

        if (!await scheduler.CheckExists(new JobKey(transaction.Name, "businessTransactions")))
        {
            transaction.Recurrent = true;

            IJobDetail jd = JobBuilder.Create<BusinessTransactionJob>().WithIdentity(transaction.Name, "businessTransactions").Build();
            jd.JobDataMap["transaction"] = transaction;

            ITrigger? tg = TriggerBuilder.Create().WithIdentity(transaction.Name, "businessTransactions").ForJob(transaction.Name, "businessTransactions")
                .StartNow()
                .WithSimpleSchedule(s => s.WithInterval(TimeSpan.FromSeconds((int)interval)).WithRepeatCount(10)).Build();

            await scheduler.ScheduleJob(jd, tg);
            if (!scheduler.IsStarted) await scheduler.Start();
        }
    }

    [HttpPost]
    public async void StopAuto([FromBody] BusinessTransaction transaction)
    {
        IReadOnlyList<IScheduler> schedulers = await _quartzScheduler.GetAllSchedulers();
        IScheduler? scheduler = schedulers.FirstOrDefault(x => x.CheckExists(new JobKey(transaction.Name, "businessTransactions")).Result);
        if (scheduler != null) await scheduler.Shutdown();
    }

    [HttpGet]
    public async Task<List<BusinessTransaction>?> GetCurrentAutos()
    {
        IReadOnlyList<IScheduler> schedulers = await _quartzScheduler.GetAllSchedulers();

        List<BusinessTransaction>? transactions = await _context.Transactions.Where(x => x.Recurrent).Include(x => x.Category).Include(x => x.Supplier).ToListAsync();
        transactions = transactions.DistinctBy(x => x.Name).ToList();
        List<BusinessTransaction>? currentAutos = [];

        foreach(BusinessTransaction tr in transactions)
        {
            IScheduler? sch = schedulers.FirstOrDefault(x => x.CheckExists(new JobKey(tr.Name, "businessTransactions")).Result);
            if (sch != null) currentAutos.Add(tr);
        }

        return currentAutos;
    }
}