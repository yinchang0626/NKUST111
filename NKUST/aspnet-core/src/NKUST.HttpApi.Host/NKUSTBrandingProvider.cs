using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace NKUST;

[Dependency(ReplaceServices = true)]
public class NKUSTBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "NKUST";
}
