using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Xunmei.Docs.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Xunmei.Docs.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits Xunmei.Docs.Web.Pages.DocsPage
     */
    public abstract class DocsPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<DocsResource> L { get; set; }
    }
}
