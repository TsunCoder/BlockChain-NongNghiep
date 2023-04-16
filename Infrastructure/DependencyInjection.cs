using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            MongoClientSettings settings = MongoClientSettings.FromConnectionString(
                Environment.GetEnvironmentVariable("")
            );

            settings.LinqProvider = MongoDB.Driver.Linq.LinqProvider.V3;

            MongoClient client = new MongoClient(settings);

            return services;
        }
    }
}
