using ATSProServer.Domain.AppEntities.Identity;

namespace ATSProServer.Application.Features.AppFeatures.RoleFeatures.Queries.GetAllRoles
{
    public sealed record GetAllRolesCommandResponse(
       IList<AppRole> Roles);
    
}
