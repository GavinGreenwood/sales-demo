using System.Collections.Generic;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace SalesDemo.Web.Authentication.JwtBearer
{
    public class AsyncJwtBearerOptions : JwtBearerOptions
    {
        public readonly List<IAsyncSecurityTokenValidator> AsyncSecurityTokenValidators;
        
        private readonly SalesDemoAsyncJwtSecurityTokenHandler _defaultAsyncHandler = new SalesDemoAsyncJwtSecurityTokenHandler();

        public AsyncJwtBearerOptions()
        {
            AsyncSecurityTokenValidators = new List<IAsyncSecurityTokenValidator>() {_defaultAsyncHandler};
        }
    }

}
