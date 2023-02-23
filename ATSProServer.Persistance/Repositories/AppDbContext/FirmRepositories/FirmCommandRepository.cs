using ATSProServer.Domain.AppEntities;
using ATSProServer.Domain.Repositories.AppDbContext.FirmRepositories;
using ATSProServer.Persistance.Repository.GenericRepositories.AppDbContext;

namespace ATSProServer.Persistance.Repositories.AppDbContext.FirmRepositories
{
    public sealed class FirmCommandRepository : AppCommandRepository<Firm>, IFirmCommandRepository
    {
        public FirmCommandRepository(Context.AppDbContext contex) : base(contex)
        {
        }
    }
}