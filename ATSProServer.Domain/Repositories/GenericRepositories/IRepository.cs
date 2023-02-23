using ATSProServer.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace ATSProServer.Domain.Repositories.GenericRepositories;

public interface IRepository<T>
    where T : Entity
{
    public DbSet<T> Entity { get; set; }
}
