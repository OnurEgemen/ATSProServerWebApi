using ATSProServer.Application.Messaging;

namespace ATSProServer.Application.Features.AppFeatures.RoleFeatures.Queries.GetAllRoles
{
    public sealed record GetAllRolesCommand() : IQuery<GetAllRolesCommandResponse>;
    
}
