using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Xunmei.Docs.Data
{
    /* This is used if database provider does't define
     * IDocsDbSchemaMigrator implementation.
     */
    public class NullDocsDbSchemaMigrator : IDocsDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}