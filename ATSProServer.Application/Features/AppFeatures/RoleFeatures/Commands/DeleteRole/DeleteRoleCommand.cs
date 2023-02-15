using ATSProServer.Application.Messaging;
using MediatR;

namespace ATSProServer.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole
{
    public sealed record DeleteRoleCommand(
        string Id) : ICommand<DeleteRoleCommandResponse>;
    
}
