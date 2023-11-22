using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace SalesDemo.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
