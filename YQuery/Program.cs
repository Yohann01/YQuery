using Microsoft.Extensions.DependencyInjection;
using YQuery.Service;
using YQuery.Service.Service;
using YQuery.Shared.Model;

namespace YQuery
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var services = new ServiceCollection();

            // Register the credentials service
            services.AddSingleton<ICredentialsService, CredentialsService>();

            // Register infrastructure services
            services.AddSingleton<IRegisterInfraAccess>(sp =>
                RegisterInfraAccess.GetInstance(sp.GetRequiredService<ICredentialsService>())
            );

            services.AddTransient<IConnectionService>(sp =>
                new ConnectionService(
                    sp.GetRequiredService<IRegisterInfraAccess>()
                ));

            services.AddTransient<YQuery>();

            using var serviceProvider = services.BuildServiceProvider();

            var mainForm = serviceProvider.GetRequiredService<YQuery>();
            Application.Run(mainForm);
        }
    }
}