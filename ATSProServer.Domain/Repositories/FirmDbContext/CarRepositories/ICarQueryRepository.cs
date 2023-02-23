using ATSProServer.Domain.FirmEntities;
using ATSProServer.Domain.Repositories.GenericRepositories.CompanyDbContext;

namespace ATSProServer.Domain.Repositories.CompanyDbContext.CarRepositories
{
    public interface ICarQueryRepository : IFirmDbQueryRepository<Car>
    {
    }
}
