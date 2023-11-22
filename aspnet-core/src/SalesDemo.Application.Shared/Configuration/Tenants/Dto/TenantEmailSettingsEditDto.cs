using Abp.Auditing;
using SalesDemo.Configuration.Dto;

namespace SalesDemo.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}