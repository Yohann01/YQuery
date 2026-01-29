using Microsoft.Extensions.DependencyInjection;
using YQuery.Shared.Model;

namespace YQuery
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var services = new ServiceCollection();


            services.AddTransient<YQuery>();
            services.AddSingleton<UserSession>();

            using var serviceProvider = services.BuildServiceProvider();

            // 6️⃣ Resolve main form via DI
            var mainForm = serviceProvider.GetRequiredService<YQuery>();

            Application.Run(mainForm);
        }
    }
}