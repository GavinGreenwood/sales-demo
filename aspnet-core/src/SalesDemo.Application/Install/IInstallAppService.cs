using System.Threading.Tasks;
using Abp.Application.Services;
using SalesDemo.Install.Dto;

namespace SalesDemo.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}