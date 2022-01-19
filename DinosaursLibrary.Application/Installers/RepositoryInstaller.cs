using DinosaursLibrary.Infrastructure.Interfaces;
using DinosaursLibrary.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DinosaursLibrary.Application.Installers
{
    public static class RepositoryInstaller
    {
        public static IServiceCollection AddRepositoryServices(this IServiceCollection services)
        {
            services.AddScoped<RepositoryBase>();
            services.AddScoped<IDinosaurRepository, DinosaurRepository>();

            return services;
        }
    }
}