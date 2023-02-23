using MediatR;
using ATSProServer.Presentation.Abstraction;
using Microsoft.AspNetCore.Mvc;
using ATSProServer.Application.Features.FirmFeatures.CarFeatures.Commands.CreateCar;

namespace ATSProServer.Presentation.Controller
{
    public sealed class CarsController : ApiController
    {
        public CarsController(IMediator mediator) : base(mediator) 
        {

        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateCar(CreateCarCommand request,
            CancellationToken cancellationToken)
        {
            CreateCarCommandResponse response= await _mediator.Send(request, 
                cancellationToken);
            return Ok(response);
        }
    }
}
