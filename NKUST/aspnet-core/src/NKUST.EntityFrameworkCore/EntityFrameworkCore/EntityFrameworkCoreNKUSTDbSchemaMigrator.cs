using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NKUST.Data;
using Volo.Abp.DependencyInjection;

namespace NKUST.EntityFrameworkCore;

public class EntityFrameworkCoreNKUSTDbSchemaMigrator
    : INKUSTDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreNKUSTDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the NKUSTDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<NKUSTDbContext>()
            .Database
            .MigrateAsync();
    }
}
