using Budget.Database;
using Budget.DataModels.BusinessModels;
using Budget.DataModels.PersonalModels;
using Quartz;
using System.Diagnostics;

namespace Budget.DataModels;

public class BusinessTransactionJob : IJob
{
    private readonly BusinessTransactionContext _context;
    private BusinessTransaction _transaction = new();

    public BusinessTransactionJob(BusinessTransactionContext context) => _context = context;

    public async Task Execute(IJobExecutionContext jContext)
    {
        try
        {
            JobDataMap jdm = jContext.JobDetail.JobDataMap;

            _transaction = (BusinessTransaction)jdm["transaction"];
            _transaction.Id = 0;
            _context.Transactions.Add(_transaction);
            await _context.SaveChangesAsync();
        }
        catch (Exception ex) { Debug.WriteLine(ex.Message); }
    }
}

public class PersonalTransactionJob : IJob
{
    private readonly PersonalTransactionContext _context;
    private PersonalTransaction _transaction = new();

    public PersonalTransactionJob(PersonalTransactionContext context) => _context = context;

    public async Task Execute(IJobExecutionContext jContext)
    {
        try
        {
            JobDataMap jdm = jContext.JobDetail.JobDataMap;

            _transaction = (PersonalTransaction)jdm["transaction"];
            _transaction.Id = 0;
            _context.Transactions.Add(_transaction);
            await _context.SaveChangesAsync();
        }
        catch(Exception ex) { Debug.WriteLine(ex.Message); }
    }
}
