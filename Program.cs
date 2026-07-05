using Budget.Database;
using Budget.DataModels;
using Quartz;

namespace Budget
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<BusinessTransactionContext>();
            builder.Services.AddDbContext<PersonalTransactionContext>();
            builder.Services.AddControllers();

            builder.Services.AddQuartz().AddQuartzHostedService(opt => { opt.WaitForJobsToComplete = true; });
            builder.Services.AddTransient<BusinessTransactionJob>();

            WebApplication app = builder.Build();

            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=PersonalTransaction}/{action=GetAll}/{id?}");

            app.Run();
        }
    }
}