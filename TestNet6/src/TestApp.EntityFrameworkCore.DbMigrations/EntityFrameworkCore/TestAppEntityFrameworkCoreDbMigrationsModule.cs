using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace TestApp.EntityFrameworkCore
{
    [DependsOn(
        typeof(TestAppEntityFrameworkCoreModule)
        )]
    public class TestAppEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<TestAppMigrationsDbContext>();
        }
    }
}
