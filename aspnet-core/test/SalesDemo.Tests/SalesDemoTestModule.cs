using Abp.Modules;
using SalesDemo.Test.Base;

namespace SalesDemo.Tests
{
    [DependsOn(typeof(SalesDemoTestBaseModule))]
    public class SalesDemoTestModule : AbpModule
    {
       
    }
}
