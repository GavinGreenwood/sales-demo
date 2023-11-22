using Abp.AspNetCore.Mvc.ViewComponents;

namespace SalesDemo.Web.Public.Views
{
    public abstract class SalesDemoViewComponent : AbpViewComponent
    {
        protected SalesDemoViewComponent()
        {
            LocalizationSourceName = SalesDemoConsts.LocalizationSourceName;
        }
    }
}