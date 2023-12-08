using CleanArch.Application.Interfaces;
using CleanArch.Domain.IRepositores;
using CleanArch.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infrastructure
{
    public static class ServiceCollectionExtension
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IContactRepository, ContactRepository>();
            //services.AddTransient<IContactRepository, ContactRepositoryEF>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
