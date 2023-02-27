using ATSProServer.Domain;
using ATSProServer.Domain.AppEntities;
using ATSProServer.Domain.UnitOfWorks;
using ATSProServer.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace ATSProServer.Persistance
{
    public sealed class ContextService : IContextService
    {
        private readonly AppDbContext _appContext;

        public ContextService(AppDbContext appContext)
        {
            _appContext = appContext;
        }

        public DbContext CreateDbContextInstance(string FirmId)
        {
            Firm firm = _appContext.Set<Firm>().Find(FirmId);
            return new FirmDbContext(firm);
        }

        
    }
}
