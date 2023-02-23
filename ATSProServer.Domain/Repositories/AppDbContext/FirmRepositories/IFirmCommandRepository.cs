using ATSProServer.Domain.AppEntities;
using ATSProServer.Domain.Repositories.GenericRepositories.AppDbContext;

namespace ATSProServer.Domain.Repositories.AppDbContext.FirmRepositories;

public interface IFirmCommandRepository : IAppCommandRepository<Firm>
{
}
