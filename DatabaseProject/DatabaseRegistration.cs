using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System;

namespace DatabaseProject
{
    public static class DatabaseRegistration
    {
        public const string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EntityFrameworkExample;Integrated Security=True";

        public static void RegisterDatabaseProject(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<TransactionContext>(
                options => options.UseSqlServer(connectionString)
            );
        }
    }
}
