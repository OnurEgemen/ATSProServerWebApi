using ATSProServer.Domain.Abstractions;
using ATSProServer.Domain.Repositories;
using ATSProServer.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ATSProServer.Persistance.Repository
{
    public class QueryRepository<T> : IQueryRepository<T>
        where T : Entity
    {
        private static readonly Func<FirmDbContext, string, bool, Task<T>> GetByIdCompiled =
          EF.CompileAsyncQuery((FirmDbContext context, string id, bool isTracking) =>
            isTracking == true 
            ? context.Set<T>().FirstOrDefault(x => x.Id == id) 
            : context.Set<T>().AsNoTracking().FirstOrDefault(x => x.Id == id));

        private static readonly Func<FirmDbContext,bool, Task<T>> GetFirstCompiled =
          EF.CompileAsyncQuery((FirmDbContext context, bool isTracking) =>
            isTracking == true
            ? context.Set<T>().FirstOrDefault()
            : context.Set<T>().AsNoTracking().FirstOrDefault());

        private static readonly Func<FirmDbContext, Expression<Func<T, bool>> , bool, Task<T>> GetFirstByExpressionCompiled =
          EF.CompileAsyncQuery((FirmDbContext context, Expression<Func<T, bool>> expression, 
              bool isTracking) =>
                isTracking == true 
                ? context.Set<T>().FirstOrDefault(expression)
                : context.Set<T>().AsNoTracking().FirstOrDefault(expression));



        private FirmDbContext _context;
        public DbSet<T> Entity { get; set; }

        public void SetDbContextInstance(DbContext context)
        {
            _context = (FirmDbContext)context;
            Entity = _context.Set<T>();
        }

        public IQueryable<T> GetAll(bool isTracking = true)
        {
            var result = Entity.AsQueryable();
            if (!isTracking)
                result =result.AsNoTracking();
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

        public async Task<T> GetFirstByExpression(Expression<Func<T, bool>> expression, bool isTracking = true)
        {
            return await GetFirstByExpressionCompiled(_context,expression, isTracking);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> expression, bool isTracking = true)
        {
            var result = Entity.Where(expression);
            if(!isTracking) 
                result = result.AsNoTracking();

            return result;
        }
    }
}
