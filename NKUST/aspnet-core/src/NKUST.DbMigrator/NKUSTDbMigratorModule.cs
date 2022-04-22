using NKUST.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace NKUST.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(NKUSTEntityFrameworkCoreModule)//,
    //typeof(NKUSTApplicationContractsModule)
    )]
public class NKUSTDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
