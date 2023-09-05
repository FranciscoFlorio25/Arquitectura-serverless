using Application.Data;
using Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infraestructure
{
    public static class DependencyInyection
    {
        public static IServiceCollection AddInfraestructure(this IServiceCollection services, IConfiguration configuration) {

            services.AddDbContext<IArqEjemploContext, ArqEjemploContext>
                (o => o.UseSqlServer(configuration.GetConnectionString("DEFAULT")));

            return services;
        }
    }
}