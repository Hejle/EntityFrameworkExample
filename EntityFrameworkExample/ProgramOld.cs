using DatabaseProject;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace EntityFrameworkExample
{
    internal class ProgramOld
    {
        public const string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EntityFrameworkExample;Integrated Security=True";

        static void Main(string[] args)
        {
            var hostBuilder = Host.CreateDefaultBuilder(args);
            hostBuilder.ConfigureServices((_, services) => ConfigureServices(services));
            var host = hostBuilder.Build().Run();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            //services.RegisterDatabaseProject();
            services.AddDbContext<TransactionContext>(
                options => options.UseSqlServer(connectionString)
            );
        }

    }
}