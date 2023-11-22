using System.Collections.Generic;
using Abp;
using SalesDemo.Chat.Dto;
using SalesDemo.Dto;

namespace SalesDemo.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
