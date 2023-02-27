using ATSProServer.Domain.UnitOfWorks;
using ATSProServer.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace ATSProServer.Persistance.UnitOfWorks
{
    public sealed class FirmDbUnitOfWork : IFirmDbUnitOfWork
    {
        private FirmDbContext _context;


        public void SetDbContextInstance(DbContext context)
        {
            _context = (FirmDbContext)context;

        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            int count = await _context.SaveChangesAsync(cancellationToken);
            return count;
        }
    }
}
