using ATSProServer.Application.Service.FirmServices;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATSProServer.Application.Features.FirmFeatures.CarFeatures.Commands.CreateCar
{
    public sealed class CreateCarHandler : IRequestHandler<CreateCarRequest, CreateCarResponse>
    {
        private readonly ICarService _carService;

        public CreateCarHandler(ICarService carService)
        {
            _carService = carService;
        }

        public async Task<CreateCarResponse> Handle(CreateCarRequest request, CancellationToken cancellationToken)
        {
            await _carService.CreateCarAsync(request);
            return new();
        }
    }
}
