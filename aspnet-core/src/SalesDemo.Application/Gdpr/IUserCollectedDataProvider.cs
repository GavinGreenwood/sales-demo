using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using SalesDemo.Dto;

namespace SalesDemo.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
