using System.Threading.Tasks;

namespace TestApp.Data
{
    public interface ITestAppDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
