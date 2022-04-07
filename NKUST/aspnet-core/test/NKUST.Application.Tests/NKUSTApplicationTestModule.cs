using Volo.Abp.Modularity;

namespace NKUST;

[DependsOn(
    typeof(NKUSTApplicationModule),
    typeof(NKUSTDomainTestModule)
    )]
public class NKUSTApplicationTestModule : AbpModule
{

}
