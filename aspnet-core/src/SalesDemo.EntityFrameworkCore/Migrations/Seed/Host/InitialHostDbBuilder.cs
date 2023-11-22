using SalesDemo.EntityFrameworkCore;

namespace SalesDemo.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly SalesDemoDbContext _context;

        public InitialHostDbBuilder(SalesDemoDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
