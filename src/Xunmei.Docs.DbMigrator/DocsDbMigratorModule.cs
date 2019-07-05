using Xunmei.Docs.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Xunmei.Docs.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(DocsEntityFrameworkCoreDbMigrationsModule),
        typeof(DocsApplicationContractsModule)
        )]
    public class DocsDbMigratorModule : AbpModule
    {
        
    }
}
