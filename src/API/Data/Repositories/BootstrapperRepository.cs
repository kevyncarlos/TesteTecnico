using API.Data.Repositories.Interfaces;

namespace API.Data.Repositories
{
    public static class BootstrapperRepository
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IClientRepository, ClientRepository>();

            return services;
        }
    }
}
