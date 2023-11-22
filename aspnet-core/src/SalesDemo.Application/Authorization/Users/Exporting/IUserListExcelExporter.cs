using System.Collections.Generic;
using SalesDemo.Authorization.Users.Dto;
using SalesDemo.Dto;

namespace SalesDemo.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}