using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using SalesDemo.EntityFrameworkCore;

namespace SalesDemo.HealthChecks
{
    public class SalesDemoDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public SalesDemoDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("SalesDemoDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("SalesDemoDbContext could not connect to database"));
        }
    }
}
