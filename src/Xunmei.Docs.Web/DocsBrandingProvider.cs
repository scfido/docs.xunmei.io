using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace Xunmei.Docs.Web
{
    [Dependency(ReplaceServices = true)]
    public class DocsBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Docs";
    }
}
