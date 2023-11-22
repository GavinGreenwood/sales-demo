using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace SalesDemo.EntityFrameworkCore
{
    public static class SalesDemoDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<SalesDemoDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<SalesDemoDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}