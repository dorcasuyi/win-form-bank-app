using System;
using System.Resources.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using DCity_Bank_Core.services;
using DCity_Bank_Core.Interface;
using DCity_Bank_Core.Calculations;
using DCity_Bank_Core.Helper;

namespace DCity_Bank
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login());

            var services = new ServiceCollection();
            ConfigureServices(services);

            using(ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var Login1 = serviceProvider.GetRequiredService<Login>();
                Application.Run(Login1);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<IUserAuthentication, UserAuthentication>();
            services.AddScoped<IWriteandRead, WriteandRead>();
            services.AddScoped<IRegexVallidators, RegexVallidators>();
            services.AddScoped<ITransactionepo, Transactionepo>();
            services.AddScoped<IAccountRepo, AccountRepo>();
            services.AddScoped<IUserRegistration, UserRegistration>();
            services.AddScoped<IUserRepos, UserRepos>();
            services.AddScoped<IUtilities, Utilities>();
            services.AddScoped<Login>();
            services.AddScoped<Register>();
        }
    }
}
