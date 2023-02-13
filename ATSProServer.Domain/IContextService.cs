using Microsoft.EntityFrameworkCore;

namespace ATSProServer.Domain
{
    public interface IContextService
    {
        DbContext CreateDbContextInstance(string FirmId);
    }
}
