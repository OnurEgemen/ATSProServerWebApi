using Microsoft.EntityFrameworkCore;

namespace ATSProServer.Domain
{
    public interface IUnitOfWork
    {
        void SetDbContextInstance(DbContext context);
        Task<int> SaveChangesAsync();

    }
}
