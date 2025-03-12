﻿using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using DataAccessLayer.Repositories;
using DataAccessLayer.RepositoryContracts;

namespace DataAccessLayer;

public static class DependencyInjection
{
    public static IServiceCollection AddDataAccessLayer(this IServiceCollection services, IConfiguration configuration)
    {
        //TO DO: Add Data Access Layer services into the IoC container

        services.AddDbContext<ApplicationDbContext>(options => {
            options.UseMySQL(configuration.GetConnectionString("DefaultConnection")!);
        });
        services.AddScoped<IProductsRepository, ProductsRepository>();

        return services;
    }
}
