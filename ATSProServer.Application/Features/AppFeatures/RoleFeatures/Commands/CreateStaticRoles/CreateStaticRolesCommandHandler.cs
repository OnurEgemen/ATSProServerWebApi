using ATSProServer.Application.Messaging;
using ATSProServer.Application.Service.AppServices;
using ATSProServer.Domain.AppEntities.Identity;
using ATSProServer.Domain.Roles;

namespace ATSProServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateAllRoles;

public sealed record CreateStaticRolesCommandHandler :
    ICommandHandler<CreateStaticRolesCommand, CreateStaticRolesCommandResponse>
{
    private readonly IRoleService _roleService;

    public CreateStaticRolesCommandHandler(IRoleService roleService)
    {
        _roleService = roleService;
    }

    public async Task<CreateStaticRolesCommandResponse> Handle(CreateStaticRolesCommand request, CancellationToken cancellationToken)
    {

        IList<AppRole> originalRoleList = RoleList.GetStaticRoles();
        IList<AppRole> newRoleList = new List<AppRole>();

        foreach (var role in originalRoleList)
        {
            AppRole checkRole = await _roleService.GetByCode(role.Code);
            if (checkRole == null) newRoleList.Add(role);
        }

        await _roleService.AddRangeAsync(newRoleList);
        return new();

    }
}
