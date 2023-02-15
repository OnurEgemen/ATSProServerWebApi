using ATSProServer.Application.Messaging;
using MediatR;

namespace ATSProServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole
{
    public sealed record CreateRoleCommand(
        string Code,
        string Name) : ICommand<CreateRoleCommandResponse>;
    
}
