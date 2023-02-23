using ATSProServer.Domain.Abstractions;
using ATSProServer.Domain.Repositories.AppDbContext.FirmRepositories;
using System.Linq.Expressions;

namespace ATSProServer.Domain.Repositories.GenericRepositories.CompanyDbContext
{
    public interface IFirmDbQueryRepository<T> : IFirmDbRepository<T>,IQueryGenericRepository<T>
        where T : Entity
    {
      

    }
}
