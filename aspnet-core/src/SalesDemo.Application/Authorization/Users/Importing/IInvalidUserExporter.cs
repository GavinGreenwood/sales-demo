using System.Collections.Generic;
using SalesDemo.Authorization.Users.Importing.Dto;
using SalesDemo.Dto;

namespace SalesDemo.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
