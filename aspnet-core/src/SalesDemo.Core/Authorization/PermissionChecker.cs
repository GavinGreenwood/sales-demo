using Abp.Authorization;
using SalesDemo.Authorization.Roles;
using SalesDemo.Authorization.Users;

namespace SalesDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
