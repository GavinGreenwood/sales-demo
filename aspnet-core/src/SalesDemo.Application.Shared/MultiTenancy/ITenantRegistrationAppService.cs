using System.Threading.Tasks;
using Abp.Application.Services;
using SalesDemo.Editions.Dto;
using SalesDemo.MultiTenancy.Dto;

namespace SalesDemo.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}