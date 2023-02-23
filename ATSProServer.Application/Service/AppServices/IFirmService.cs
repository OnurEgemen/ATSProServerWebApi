using ATSProServer.Application.Features.AppFeatures.FirmFeatures.Commands.CreateFirm;
using ATSProServer.Domain.AppEntities;

namespace ATSProServer.Application.Service.AppServices
{
    public interface IFirmService
    {
        Task CreateFirm(CreateFirmCommand request, CancellationToken cancellationToken);
        Task MigrateFirmDatabases();
        Task <Firm?> GetFirmByName(string name);
    }
}
