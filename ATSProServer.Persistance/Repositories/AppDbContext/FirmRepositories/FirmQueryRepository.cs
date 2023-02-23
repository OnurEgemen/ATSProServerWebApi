using ATSProServer.Domain.AppEntities;
using ATSProServer.Domain.Repositories.AppDbContext.FirmRepositories;
using ATSProServer.Persistance.Repository.GenericRepositories.AppDbContext;

namespace ATSProServer.Persistance.Repositories.AppDbContext.FirmRepositories;

public sealed class FirmQueryRepository : AppQueryRepository<Firm>, IFirmQueryRepository
{
    public FirmQueryRepository(Context.AppDbContext context) : base(context)
    {
    }
}
