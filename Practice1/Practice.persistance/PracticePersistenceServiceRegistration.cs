using CineFlex.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Practice.Application.Contract;
using Practice.Application.Contrat;
using Practice.persistance.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.persistance
{
    public static class PracticePersistenceServiceRegistration
    {
        public static IServiceCollection ConfigurePersistenceServices( this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<PracticeDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("PracticeConnectionString")));
            services.AddScoped ( typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<ICinemaRepository, CinemaRepository>();
            return services;
        }
    }
}
