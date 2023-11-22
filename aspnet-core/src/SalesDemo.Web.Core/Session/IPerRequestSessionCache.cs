using System.Threading.Tasks;
using SalesDemo.Sessions.Dto;

namespace SalesDemo.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
