using TestApp.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace TestApp.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(TestAppEntityFrameworkCoreDbMigrationsModule),
        typeof(TestAppApplicationContractsModule)
        )]
    public class TestAppDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
