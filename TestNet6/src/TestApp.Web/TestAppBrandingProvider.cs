using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace TestApp.Web
{
    [Dependency(ReplaceServices = true)]
    public class TestAppBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "TestApp";
    }
}
