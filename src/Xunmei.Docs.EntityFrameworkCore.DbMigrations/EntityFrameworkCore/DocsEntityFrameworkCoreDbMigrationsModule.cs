using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace Xunmei.Docs.EntityFrameworkCore
{
    [DependsOn(
            typeof(Volo.Docs.EntityFrameworkCore.DocsEntityFrameworkCoreModule),
            typeof(DocsEntityFrameworkCoreModule)
        )]
    public class DocsEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<DocsMigrationsDbContext>();
        }
    }
}
