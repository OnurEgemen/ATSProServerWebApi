using ATSProServer.Application.Messaging;

namespace ATSProServer.Application.Features.AppFeatures.FirmFeatures.Commands.CreateFirm
{
    public sealed record CreateFirmCommand (
        string FirmName,
        string ServerName,
        string DatabaseName,
        string UserId,
        string Password): ICommand<CreateFirmCommandResponse>;
    
}
