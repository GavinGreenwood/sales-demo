using Abp.Modules;
using Abp.Reflection.Extensions;

namespace SalesDemo
{
    public class SalesDemoCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SalesDemoCoreSharedModule).GetAssembly());
        }
    }
}