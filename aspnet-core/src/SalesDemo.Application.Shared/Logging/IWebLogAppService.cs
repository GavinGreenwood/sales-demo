using Abp.Application.Services;
using SalesDemo.Dto;
using SalesDemo.Logging.Dto;

namespace SalesDemo.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
