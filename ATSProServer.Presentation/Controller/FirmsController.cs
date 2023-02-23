using ATSProServer.Application.Features.AppFeatures.FirmFeatures.Commands.CreateFirm;
using ATSProServer.Application.Features.AppFeatures.FirmFeatures.Commands.MigrateFirmDatabase;
using ATSProServer.Presentation.Abstraction;
using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace ATSProServer.Presentation.Controller
{
    public class FirmsController : ApiController
    {
        public FirmsController(IMediator mediator) : base(mediator) 
        {

        }

        [HttpPost("[action]")]
        public async Task<IActionResult>CreateFirm(CreateFirmCommand request, 
            CancellationToken cancellationToken)
        {
            CreateFirmCommandResponse response = await _mediator.Send(request,
                cancellationToken);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> MigrateFirmDatabases()
        {
            MigrateFirmDatabasesCommand request = new();
            MigrateFirmDatabasesCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
