using Abp.AspNetCore.Mvc.Views;

namespace SalesDemo.Web.Views
{
    public abstract class SalesDemoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected SalesDemoRazorPage()
        {
            LocalizationSourceName = SalesDemoConsts.LocalizationSourceName;
        }
    }
}
