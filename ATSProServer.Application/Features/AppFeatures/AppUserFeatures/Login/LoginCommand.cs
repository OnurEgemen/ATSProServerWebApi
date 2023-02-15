using ATSProServer.Application.Messaging;

namespace ATSProServer.Application.Features.AppFeatures.AppUserFeatures.Login
{
    public sealed record LoginCommand(
        string EmailOrUsername,
        string Password) : ICommand<LoginCommandResponse>;
}
