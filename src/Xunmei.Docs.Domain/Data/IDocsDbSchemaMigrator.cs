using System.Threading.Tasks;

namespace Xunmei.Docs.Data
{
    public interface IDocsDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
