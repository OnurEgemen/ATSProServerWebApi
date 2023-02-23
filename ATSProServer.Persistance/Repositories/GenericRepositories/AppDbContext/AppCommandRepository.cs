using ATSProServer.Domain.Abstractions;
using ATSProServer.Domain.Repositories.GenericRepositories.AppDbContext;
using Microsoft.EntityFrameworkCore;

namespace ATSProServer.Persistance.Repository.GenericRepositories.AppDbContext;

public class AppCommandRepository<T> : IAppCommandRepository<T>
    where T : Entity
{

    private readonly Context.AppDbContext _context;

    public AppCommandRepository(Context.AppDbContext contex)
    {
        _context = contex;
        Entity = _context.Set<T>();
    }

    private static readonly Func<Context.AppDbContext, string, Task<T>> GetByIdCompiled =
            EF.CompileAsyncQuery((Context.AppDbContext context, string id) =>
            context.Set<T>().FirstOrDefault(x => x.Id == id));

    public DbSet<T> Entity { get; set; }



    public async Task AddAsync(T entity, CancellationToken cancellationToken)
    {
        await Entity.AddAsync(entity, cancellationToken);
    }

    public async Task AddRangeAsync(IEnumerable<T> entities, CancellationToken cancellationToken)
    {
        await Entity.AddRangeAsync(entities, cancellationToken);
    }


    public void Remove(T entity)
    {
        Entity.Remove(entity);
    }

    public async Task RemoveById(string id)
    {
        T entity = await GetByIdCompiled( _context, id);
        Remove(entity);
    }

    public void RemoveRange(IEnumerable<T> entities)
    {
        Entity.RemoveRange(entities);
    }

    public void Update(T entity)
    {
        Entity.Update(entity);
    }

    public void UpdateRange(IEnumerable<T> entities)
    {
        Entity.UpdateRange(entities);
    }
}
