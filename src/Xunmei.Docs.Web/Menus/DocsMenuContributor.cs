using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using Xunmei.Docs.Localization;
using Xunmei.Docs.MultiTenancy;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace Xunmei.Docs.Web.Menus
{
    public class DocsMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            if (!MultiTenancyConsts.IsEnabled)
            {
                var administration = context.Menu.GetAdministration();
                administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
            }

            var l = context.ServiceProvider.GetRequiredService<IStringLocalizer<DocsResource>>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem("Docs.Home", l["Menu:Home"], "/"));
            context.Menu.Items.Add(new ApplicationMenuItem("Docs.Docs", l["Menu:Docs"], "/Documents"));

        }
    }
}
