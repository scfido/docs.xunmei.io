using Volo.Abp.Modularity;

namespace Xunmei.Docs
{
    [DependsOn(
        typeof(DocsApplicationModule),
        typeof(DocsDomainTestModule)
        )]
    public class DocsApplicationTestModule : AbpModule
    {

    }
}