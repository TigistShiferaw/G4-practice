using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CineFlex.Persistence;

namespace Practice.persistance
{
    internal class PracticeDbContextFactory
    {
        public PracticeDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json")
                 .Build();

            var builder = new DbContextOptionsBuilder<PracticeDbContext>();
            var connectionString = configuration.GetConnectionString("PracticeConnectionString");

            builder.UseNpgsql(connectionString);

            return new PracticeDbContext(builder.Options);
        }
    }
}
