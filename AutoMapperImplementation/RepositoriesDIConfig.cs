using AutoMapperImplementation.Repositories;
using AutoMapperImplementation.Repositories.Interfaces;

namespace AutoMapperImplementation
{
    public static class RepositoriesDIConfig
    {
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}
