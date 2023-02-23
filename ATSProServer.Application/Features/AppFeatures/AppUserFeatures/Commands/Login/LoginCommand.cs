using ATSProServer.Application.Messaging;

namespace ATSProServer.Application.Features.AppFeatures.AppUserFeatures.Commands.Login
{
    public sealed record LoginCommand(
        string EmailOrUsername,
        string Password) : ICommand<LoginCommandResponse>;
}
