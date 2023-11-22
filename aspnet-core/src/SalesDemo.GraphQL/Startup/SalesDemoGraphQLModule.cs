using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace SalesDemo.Startup
{
    [DependsOn(typeof(SalesDemoCoreModule))]
    public class SalesDemoGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SalesDemoGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}