using System.Collections.Generic;
using Abp.Application.Services.Dto;
using SalesDemo.Editions.Dto;

namespace SalesDemo.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}