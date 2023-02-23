using ATSProServer.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace ATSProServer.Domain.Repositories.GenericRepositories.AppDbContext
{
    public interface IAppCommandRepository<T> : ICommandGenericRepository<T>,
        IRepository<T>
        where T : Entity
    {
        
    }
}
