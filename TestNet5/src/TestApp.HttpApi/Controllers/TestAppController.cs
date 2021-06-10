using TestApp.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TestApp.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class TestAppController : AbpController
    {
        protected TestAppController()
        {
            LocalizationResource = typeof(TestAppResource);
        }
    }
}