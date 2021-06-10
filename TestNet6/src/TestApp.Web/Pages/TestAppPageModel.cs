using TestApp.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace TestApp.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class TestAppPageModel : AbpPageModel
    {
        protected TestAppPageModel()
        {
            LocalizationResourceType = typeof(TestAppResource);
        }
    }
}