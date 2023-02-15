using ATSProServer.Application.Messaging;
using ATSProServer.Application.Service.FirmServices;

namespace ATSProServer.Application.Features.FirmFeatures.CarFeatures.Commands.CreateCar
{
    public sealed class CreateCarCommandHandler : ICommandHandler<CreateCarCommand, CreateCarCommandResponse>
    {
        private readonly ICarService _carService;

        public CreateCarCommandHandler(ICarService carService)
        {
            _carService = carService;
        }

        public async Task<CreateCarCommandResponse> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            await _carService.CreateCarAsync(request);
            return new();
        }
    }
}
