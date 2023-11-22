using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using SalesDemo.Configure;
using SalesDemo.Startup;
using SalesDemo.Test.Base;

namespace SalesDemo.GraphQL.Tests
{
    [DependsOn(
        typeof(SalesDemoGraphQLModule),
        typeof(SalesDemoTestBaseModule))]
    public class SalesDemoGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SalesDemoGraphQLTestModule).GetAssembly());
        }
    }
}