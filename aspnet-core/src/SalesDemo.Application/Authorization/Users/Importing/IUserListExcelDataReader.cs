using System.Collections.Generic;
using SalesDemo.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace SalesDemo.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
