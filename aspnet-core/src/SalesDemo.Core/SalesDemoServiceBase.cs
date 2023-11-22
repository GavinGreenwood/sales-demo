using Abp;

namespace SalesDemo
{
    /// <summary>
    /// This class can be used as a base class for services in this application.
    /// It has some useful objects property-injected and has some basic methods most of services may need to.
    /// It's suitable for non domain nor application service classes.
    /// For domain services inherit <see cref="SalesDemoDomainServiceBase"/>.
    /// For application services inherit SalesDemoAppServiceBase.
    /// </summary>
    public abstract class SalesDemoServiceBase : AbpServiceBase
    {
        protected SalesDemoServiceBase()
        {
            LocalizationSourceName = SalesDemoConsts.LocalizationSourceName;
        }
    }
}