using Microsoft.Extensions.DependencyInjection;
using SistemaGestionBussiness.Services;
using SistemaGestionData;

namespace SistemaGestionBussiness
{
    public static class ConfigureServices
    {
        public static IServiceCollection ConfigureBussinessLayer(this IServiceCollection services)
        {
            services.ConfigureDataLayer();
            services.AddScoped<ProductosService>();
            services.AddScoped<UsuariosService>();
            services.AddScoped<ProductosVendidosService>();
            services.AddScoped<VentasService>();
            return services;
        }
    }
}
