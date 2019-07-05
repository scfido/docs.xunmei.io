using Xunmei.Docs.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Xunmei.Docs
{
    [DependsOn(
        typeof(DocsEntityFrameworkCoreTestModule)
        )]
    public class DocsDomainTestModule : AbpModule
    {

    }
}