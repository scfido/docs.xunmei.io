using Xunmei.Docs.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Xunmei.Docs.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class DocsPageModel : AbpPageModel
    {
        protected DocsPageModel()
        {
            LocalizationResourceType = typeof(DocsResource);
        }
    }
}