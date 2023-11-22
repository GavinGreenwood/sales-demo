using Abp.Modules;
using Abp.Reflection.Extensions;

namespace SalesDemo
{
    [DependsOn(typeof(SalesDemoCoreSharedModule))]
    public class SalesDemoApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SalesDemoApplicationSharedModule).GetAssembly());
        }
    }
}