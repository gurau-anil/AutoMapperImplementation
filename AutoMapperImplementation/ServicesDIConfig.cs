using AutoMapperImplementation.Services;
using AutoMapperImplementation.Services.Interfaces;

namespace AutoMapperImplementation
{
    public static class ServicesDIConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IProductService, ProductService>();
        }
    }
}
