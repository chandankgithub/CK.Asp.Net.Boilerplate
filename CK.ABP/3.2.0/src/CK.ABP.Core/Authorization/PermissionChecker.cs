using Abp.Authorization;
using CK.ABP.Authorization.Roles;
using CK.ABP.Authorization.Users;

namespace CK.ABP.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
