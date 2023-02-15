using ATSProServer.Application.Messaging;
using ATSProServer.Application.Service.AppServices;

namespace ATSProServer.Application.Features.AppFeatures.FirmFeatures.Commands.MigrateFirmDatabase
{
    public sealed class MigrateFirmDatabasesCommandHandler :
        ICommandHandler<MigrateFirmDatabasesCommand, MigrateFirmDatabasesCommandResponse>
    {
        private readonly IFirmService _firmService;

        public MigrateFirmDatabasesCommandHandler(IFirmService firmService)
        {
            _firmService = firmService;
        }

        public async Task<MigrateFirmDatabasesCommandResponse> Handle
            (MigrateFirmDatabasesCommand request, CancellationToken cancellationToken)
        {
            await _firmService.MigrateFirmDatabases();
            return new();
        }
    }
}
