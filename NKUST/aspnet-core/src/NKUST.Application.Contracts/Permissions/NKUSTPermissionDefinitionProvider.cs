using NKUST.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace NKUST.Permissions;

public class NKUSTPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(NKUSTPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(NKUSTPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<NKUSTResource>(name);
    }
}
