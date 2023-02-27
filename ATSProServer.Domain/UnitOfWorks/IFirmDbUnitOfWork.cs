using Microsoft.EntityFrameworkCore;

namespace ATSProServer.Domain.UnitOfWorks
{
    public interface IFirmDbUnitOfWork : IUnitOfWork
    {
        void SetDbContextInstance(DbContext context);

    }
}
