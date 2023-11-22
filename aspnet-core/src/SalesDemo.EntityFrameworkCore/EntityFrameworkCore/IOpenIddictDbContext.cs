using Microsoft.EntityFrameworkCore;
using SalesDemo.OpenIddict.Applications;
using SalesDemo.OpenIddict.Authorizations;
using SalesDemo.OpenIddict.Scopes;
using SalesDemo.OpenIddict.Tokens;

namespace SalesDemo.EntityFrameworkCore
{
    public interface IOpenIddictDbContext
    {
        DbSet<OpenIddictApplication> Applications { get; }

        DbSet<OpenIddictAuthorization> Authorizations { get; }

        DbSet<OpenIddictScope> Scopes { get; }

        DbSet<OpenIddictToken> Tokens { get; }
    }

}