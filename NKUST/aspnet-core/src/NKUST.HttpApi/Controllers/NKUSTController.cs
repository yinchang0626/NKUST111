using NKUST.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace NKUST.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class NKUSTController : AbpControllerBase
{
    protected NKUSTController()
    {
        LocalizationResource = typeof(NKUSTResource);
    }
}
