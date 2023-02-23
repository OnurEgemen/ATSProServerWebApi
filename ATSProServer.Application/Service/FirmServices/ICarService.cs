using ATSProServer.Application.Features.FirmFeatures.CarFeatures.Commands.CreateCar;
using ATSProServer.Domain.FirmEntities;

namespace ATSProServer.Application.Service.FirmServices
{
    public interface ICarService
    {
        Task CreateCarAsync(CreateCarCommand request, CancellationToken cancellationToken);

        Task<Car> GetByCarId(string CarId);
    }
}
