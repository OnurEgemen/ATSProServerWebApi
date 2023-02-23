using ATSProServer.Domain.Abstractions;
using ATSProServer.Domain.Repositories.AppDbContext.FirmRepositories;
using Microsoft.EntityFrameworkCore;

namespace ATSProServer.Domain.Repositories.GenericRepositories.CompanyDbContext
{
    public interface IFirmDbCommandRepository<T> : IFirmDbRepository<T> , ICommandGenericRepository<T>
        where T : Entity
    {
        
    }
}
