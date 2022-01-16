using DinosaursLibrary.Application.Interfaces;
using DinosaursLibrary.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace DinosaursLibrary.Application.Installers
{
    public static class ServiceInstaller
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddSingleton<IDinosaurService, DinosaurService>();

            return services;
        }
    }
}