using Microsoft.Extensions.Configuration;

namespace SalesDemo.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
