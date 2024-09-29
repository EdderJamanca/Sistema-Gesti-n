
using Microsoft.Extensions.DependencyInjection;
using SistemaGestionData.Context;
using SistemaGestionData.DataAccess;

namespace SistemaGestionData
{
    public static class ConfigureServices
    {
        public static IServiceCollection ConfigureDataLayer(this IServiceCollection services)
        {
            services.AddDbContext<SistemaGestionContext>();
            services.AddScoped<ProductosDataAccess>();
            services.AddScoped<ProductoVendidoDataAccess>();
            services.AddScoped<UsuarioDataAccess>();
            services.AddScoped<VentaDataAccess>();
            return services;
        }
    }
}
