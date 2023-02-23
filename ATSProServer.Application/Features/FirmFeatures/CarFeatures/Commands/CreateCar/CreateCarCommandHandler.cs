using ATSProServer.Application.Messaging;
using ATSProServer.Application.Service.FirmServices;
using ATSProServer.Domain.FirmEntities;

namespace ATSProServer.Application.Features.FirmFeatures.CarFeatures.Commands.CreateCar
{
    public sealed class CreateCarCommandHandler : ICommandHandler<CreateCarCommand, CreateCarCommandResponse>
    {
        private readonly ICarService _carService;

        public CreateCarCommandHandler(ICarService carService)
        {
            _carService = carService;
        }

        public async Task<CreateCarCommandResponse> Handle(CreateCarCommand request, 
            CancellationToken cancellationToken)
        {
            Car car = await _carService.GetByCarId(request.CarId);
            if (car != null) throw new Exception("Bu araç daha önce tanımlanmış!");

            await _carService.CreateCarAsync(request, cancellationToken);
            return new();
        }
    }
}
