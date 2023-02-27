using ATSProServer.Domain.Abstractions;
using ATSProServer.Domain.Repositories.GenericRepositories.CompanyDbContext;
using ATSProServer.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ATSProServer.Persistance.Repository.GenericRepositories.FirmDbContext
{
    public class FirmDbQueryRepository<T> : IFirmDbRepository<T>
        where T : Entity
    {
        private static readonly Func<Context.FirmDbContext, string, bool, Task<T>> GetByIdCompiled =
          EF.CompileAsyncQuery((Context.FirmDbContext context, string id, bool isTracking) =>
            isTracking == true
            ? context.Set<T>().FirstOrDefault(x => x.Id == id)
            : context.Set<T>().AsNoTracking().FirstOrDefault(x => x.Id == id));

        private static readonly Func<Context.FirmDbContext, bool, Task<T>> GetFirstCompiled =
          EF.CompileAsyncQuery((Context.FirmDbContext context, bool isTracking) =>
            isTracking == true
            ? context.Set<T>().FirstOrDefault()
            : context.Set<T>().AsNoTracking().FirstOrDefault());

        private Context.FirmDbContext _context;
        public DbSet<T> Entity { get; set; }

        public void SetDbContextInstance(DbContext context)
        {
            _context = (Context.FirmDbContext)context;
            Entity = _context.Set<T>();
        }

        public IQueryable<T> GetAll(bool isTracking = true)
        {
            var result = Entity.AsQueryable();
            if (!isTracking)
                result = result.AsNoTracking();
            return result;
        }

        public async Task<T> GetById(string id, bool isTracking = true)
        {
            return await GetByIdCompiled(_context, id, isTracking);
        }

        public async Task<T> GetFirst(bool isTracking = true)
        {
            return await GetFirstCompiled(_context, isTracking);
        }

        public async Task<T> GetFirstByExpression(Expression<Func<T, bool>> expression,
            CancellationToken cancellationToken = default, bool isTracking = true)
        {
            T entity = null;
            if (!isTracking)
                entity = await Entity.AsNoTracking().Where(expression).FirstOrDefaultAsync();
            else
                entity = await Entity.Where(expression).FirstOrDefaultAsync();


            return entity;
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool isTracking = true)
        {
            var result = Entity.Where(expression);
            if (!isTracking)
                result = result.AsNoTracking();

            return result;
        }
    }
}
