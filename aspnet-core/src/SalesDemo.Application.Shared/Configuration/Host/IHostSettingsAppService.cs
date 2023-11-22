using System.Threading.Tasks;
using Abp.Application.Services;
using SalesDemo.Configuration.Host.Dto;

namespace SalesDemo.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
