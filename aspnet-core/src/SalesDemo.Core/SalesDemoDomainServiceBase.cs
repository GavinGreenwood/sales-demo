using Abp.Domain.Services;

namespace SalesDemo
{
    public abstract class SalesDemoDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected SalesDemoDomainServiceBase()
        {
            LocalizationSourceName = SalesDemoConsts.LocalizationSourceName;
        }
    }
}
