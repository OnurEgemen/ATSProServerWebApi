using ATSProServer.Domain.FirmEntities;
using ATSProServer.Domain.Repositories.CarRepositories;

namespace ATSProServer.Persistance.Repository.CarRepositories
{
    public sealed class CarQueryRepository : QueryRepository<Car> , ICarQueryRepository
    {

    }
}
