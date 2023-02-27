using ATSProServer.Application.Messaging;
using ATSProServer.Application.Service.AppServices;
using ATSProServer.Domain.AppEntities;
using ATSProServer.Domain.Roles;

namespace ATSProServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateStaticMainRoles;

public sealed class CreateStaticMainRolesHandler : ICommandHandler<CreateStaticMainRolesCommand,
    CreateStaticMainRolesResponse>
{
    private readonly IMainRoleService _mainRoleService;

    public CreateStaticMainRolesHandler(IMainRoleService mainRoleService)
    {
        _mainRoleService = mainRoleService;
    }

    public async Task<CreateStaticMainRolesResponse> Handle(CreateStaticMainRolesCommand request, 
        CancellationToken cancellationToken)
    {
        List<MainRole> mainRoles = RoleList.GetStaticMainRoles();
        List<MainRole> newMainRoles = new List<MainRole>();
        foreach (var mainRole in mainRoles) 
        {
            MainRole checkMainRole = await _mainRoleService.GetByTitleAndFirmId(mainRole.Title,
                mainRole.FirmId, cancellationToken);
            if(checkMainRole != null) newMainRoles.Add(mainRole);

        }

        await _mainRoleService.CreateRangeAsync(newMainRoles, cancellationToken);
        return new();

    }
}
