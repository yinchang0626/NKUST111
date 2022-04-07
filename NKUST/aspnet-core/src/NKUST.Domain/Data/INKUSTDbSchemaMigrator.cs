using System.Threading.Tasks;

namespace NKUST.Data;

public interface INKUSTDbSchemaMigrator
{
    Task MigrateAsync();
}
