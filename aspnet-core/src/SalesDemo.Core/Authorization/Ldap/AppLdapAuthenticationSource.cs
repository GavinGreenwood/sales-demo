using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using SalesDemo.Authorization.Users;
using SalesDemo.MultiTenancy;

namespace SalesDemo.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}