using Abp.Modules;
using Abp.Reflection.Extensions;

namespace SalesDemo
{
    public class SalesDemoClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SalesDemoClientModule).GetAssembly());
        }
    }
}
