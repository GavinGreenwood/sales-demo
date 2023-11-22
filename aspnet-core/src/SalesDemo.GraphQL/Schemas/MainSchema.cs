using Abp.Dependency;
using GraphQL.Types;
using GraphQL.Utilities;
using SalesDemo.Queries.Container;
using System;

namespace SalesDemo.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IServiceProvider provider) :
            base(provider)
        {
            Query = provider.GetRequiredService<QueryContainer>();
        }
    }
}