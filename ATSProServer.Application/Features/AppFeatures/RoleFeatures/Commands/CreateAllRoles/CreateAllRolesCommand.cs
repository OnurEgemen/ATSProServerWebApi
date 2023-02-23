using ATSProServer.Application.Messaging;
using System.Windows.Input;

namespace ATSProServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateAllRoles
{
    public sealed record CreateAllRolesCommand() : ICommand<CreateAllRolesCommandResponse>;
    
    
}
