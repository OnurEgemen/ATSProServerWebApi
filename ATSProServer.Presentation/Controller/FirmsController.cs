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
        public async Task<IActionResult>CreateFirm(CreateFirmRequest request)
        {
            CreateFirmResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> MigrateFirmDatabases()
        {
            MigrateFirmDatabasesRequest request = new();
            MigrateFirmDatabasesResponse response = await _mediator.Send(request);
            return Ok(response);
        }



    }
}
