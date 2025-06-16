using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebApi.Infrastructure
{
    public static class InfrastructureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Add Service contracts
            _ = services.AddServiceContracts();

            return services;
        }
        private static IServiceCollection AddServiceContracts(this IServiceCollection services)
        {
            //  Add TrialBalance service
            _ = services.AddTransient<ApplicationLogger>();
            _ = services.AddTransient<NotificationLogger>();

            //services.RegisterAssemblyPublicNonGenericClasses().AsPublicImplementedInterfaces();
            //services.RegisterAssemblyPublicNonGenericClasses().AsPublicImplementedInterfaces(ServiceLifetime.Transient);
            return services;
        }
    }
}
