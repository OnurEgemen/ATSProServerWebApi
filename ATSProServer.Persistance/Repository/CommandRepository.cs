using ATSProServer.Domain.Abstractions;
using ATSProServer.Domain.Repositories;
using ATSProServer.Persistance.Context;
using Microsoft.EntityFrameworkCore;

namespace ATSProServer.Persistance.Repository
{
    public class CommandRepository<T> : ICommandRepository<T>
        where T : Entity
    {
        private FirmDbContext _context;

        private static readonly Func<FirmDbContext,string,Task<T>> GetByIdCompiled =
            EF.CompileAsyncQuery((FirmDbContext context,string id)=>
            context.Set<T>().FirstOrDefault(x => x.Id == id));  

        public DbSet<T> Entity { get; set; }

        public void SetDbContextInstance(DbContext context)
        {
            _context = (FirmDbContext)context;
            Entity = _context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await Entity.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await Entity.AddRangeAsync(entities);
        }

        
        public void Remove(T entity)
        {
            Entity.Remove(entity);
        }

        public async Task RemoveById(string id)
        {
            T entity = await GetByIdCompiled(_context, id);
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
}
