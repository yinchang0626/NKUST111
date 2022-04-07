using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace NKUST.Data;

/* This is used if database provider does't define
 * INKUSTDbSchemaMigrator implementation.
 */
public class NullNKUSTDbSchemaMigrator : INKUSTDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
