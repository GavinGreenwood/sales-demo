using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SalesDemo.Authorization.Permissions.Dto;

namespace SalesDemo.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
