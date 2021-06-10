using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TestApp.Data;
using Volo.Abp.DependencyInjection;

namespace TestApp.EntityFrameworkCore
{
    public class EntityFrameworkCoreTestAppDbSchemaMigrator
        : ITestAppDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreTestAppDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the TestAppMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<TestAppMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}