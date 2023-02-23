using ATSProServer.Domain.FirmEntities;
using ATSProServer.Domain.Repositories.CompanyDbContext.CarRepositories;
using ATSProServer.Persistance.Repository.GenericRepositories.FirmDbContext;

namespace ATSProServer.Persistance.Repositories.FirmDbContext.CarRepositories;

public sealed class CarCommandRepository : FirmDbCommandRepository<Car>,ICarCommandRepository
{
}
