using ATSProServer.Application.Service.AppServices;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATSProServer.Application.Features.AppFeatures.FirmFeatures.Commands.MigrateFirmDatabase
{
    public sealed class MigrateFirmDatabasesHandler :
        IRequestHandler<MigrateFirmDatabasesRequest, MigrateFirmDatabasesResponse>
    {
        private readonly IFirmService _firmService;

        public MigrateFirmDatabasesHandler(IFirmService firmService)
        {
            _firmService = firmService;
        }

        public async Task<MigrateFirmDatabasesResponse> Handle
            (MigrateFirmDatabasesRequest request, CancellationToken cancellationToken)
        {
            await _firmService.MigrateFirmDatabases();
            return new();
        }
    }
}
