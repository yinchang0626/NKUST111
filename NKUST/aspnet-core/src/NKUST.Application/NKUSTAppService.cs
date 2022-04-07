using System;
using System.Collections.Generic;
using System.Text;
using NKUST.Localization;
using Volo.Abp.Application.Services;

namespace NKUST;

/* Inherit your application services from this class.
 */
public abstract class NKUSTAppService : ApplicationService
{
    protected NKUSTAppService()
    {
        LocalizationResource = typeof(NKUSTResource);
    }
}
