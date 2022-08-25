using System;
using CarRental.Application.Services.Repositories;
using CarRental.Persistence.Contexts;
using CarRental.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CarRental.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services,
                                                                IConfiguration configuration)
        {
            services.AddDbContext<CarRentalDbContext>(options =>
                                                     options.UseSqlServer(
                                                         configuration.GetConnectionString("Server=Server=127.0.0.1;Database=master;User Id=sa;Password=MyPass@word;")));
            services.AddScoped<IBrandRepository, BrandRepository>();

            return services;
        }
    }
}

