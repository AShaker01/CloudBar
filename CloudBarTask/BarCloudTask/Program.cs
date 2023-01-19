using BarCloudTask.Business.Services;
using CloudBarTask.Database;
using CloudBarTask.Database.Repos;
using CloudBarTask.Infrastructure.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace BarCloudTask
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ServiceCollection services = new();

            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<FrmVendors>();
                Application.Run(form1);
            }
        }
        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<GoogleSpreedSheetsReader>();
            services.AddScoped<ICloudBarSheetsAppService, CloudBarSheetsAppService>();
            services.AddScoped<IVendorsRepo, VendorsRepo>();
            services.AddScoped<FrmVendors>();
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = CloudBarVendors"));
        }
    }

}