using ATSProServer.Application.Messaging;

namespace ATSProServer.Application.Features.FirmFeatures.CarFeatures.Commands.CreateCar
{
    public sealed record CreateCarCommand(
        string CarId,
        string CarModel,
        string CarYear,
        string CarDetails,
        string FirmId) : ICommand<CreateCarCommandResponse>;
    
}
