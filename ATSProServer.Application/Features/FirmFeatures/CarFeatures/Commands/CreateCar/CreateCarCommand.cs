using ATSProServer.Application.Messaging;

namespace ATSProServer.Application.Features.FirmFeatures.CarFeatures.Commands.CreateCar
{
    public sealed record CreateCarCommand(
        string CarId,
        string CarName,
        string CarBrand,
        string CarModel,
        string CarYear,
        string CarDetails,
        string FirmId) : ICommand<CreateCarCommandResponse>;
    
}
