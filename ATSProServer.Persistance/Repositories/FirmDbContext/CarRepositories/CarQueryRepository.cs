using ATSProServer.Domain.FirmEntities;
using ATSProServer.Domain.Repositories.CompanyDbContext.CarRepositories;
using ATSProServer.Persistance.Repository.GenericRepositories.FirmDbContext;
using System.Linq.Expressions;

namespace ATSProServer.Persistance.Repositories.FirmDbContext.CarRepositories;

public sealed class CarQueryRepository : FirmDbQueryRepository<Car>, ICarQueryRepository
{
    public Task<Car> GetFirstByExpression(Expression<Func<Car, bool>> expression, CancellationToken cancellationToken = default, bool isTracking = true)
    {
        throw new NotImplementedException();
    }
}
