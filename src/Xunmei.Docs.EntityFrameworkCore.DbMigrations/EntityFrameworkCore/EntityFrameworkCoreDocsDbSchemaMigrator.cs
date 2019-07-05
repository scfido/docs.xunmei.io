using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xunmei.Docs.Data;
using Volo.Abp.DependencyInjection;

namespace Xunmei.Docs.EntityFrameworkCore
{
    [Dependency(ReplaceServices = true)]
    public class EntityFrameworkCoreDocsDbSchemaMigrator 
        : IDocsDbSchemaMigrator, ITransientDependency
    {
        private readonly DocsMigrationsDbContext _dbContext;

        public EntityFrameworkCoreDocsDbSchemaMigrator(DocsMigrationsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task MigrateAsync()
        {
            await _dbContext.Database.MigrateAsync();
        }
    }
}