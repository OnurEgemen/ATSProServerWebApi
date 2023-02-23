using ATSProServer.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace ATSProServer.Domain.Repositories.GenericRepositories.CompanyDbContext
{
    public interface IFirmDbRepository<T> : IRepository<T>
        where T : Entity
    {
        void SetDbContextInstance(DbContext context);
        
    }
}


