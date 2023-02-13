using ATSProServer.Domain;
using ATSProServer.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace ATSProServer.Persistance
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private FirmDbContext _context;


        public void SetDbContextInstance(DbContext context)
        {
            _context = (FirmDbContext)context;

        }

        public async Task<int> SaveChangesAsync()
        {
            int count = await _context.SaveChangesAsync();
            return count;
        }
    }
}
