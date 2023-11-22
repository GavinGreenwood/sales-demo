using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace SalesDemo.Web.Public.Views
{
    public abstract class SalesDemoRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected SalesDemoRazorPage()
        {
            LocalizationSourceName = SalesDemoConsts.LocalizationSourceName;
        }
    }
}
