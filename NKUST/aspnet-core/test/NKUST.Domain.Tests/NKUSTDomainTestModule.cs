using NKUST.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace NKUST;

[DependsOn(
    typeof(NKUSTEntityFrameworkCoreTestModule)
    )]
public class NKUSTDomainTestModule : AbpModule
{

}
