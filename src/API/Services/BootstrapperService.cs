using API.Services.Interfaces;

namespace API.Services
{
    public static class BootstrapperService
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IClientService, ClientService>();

            return services;
        }
    }
}
