using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace TestApp.EntityFrameworkCore
{
    public static class TestAppDbContextModelCreatingExtensions
    {
        public static void ConfigureTestApp(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(TestAppConsts.DbTablePrefix + "YourEntities", TestAppConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}