using ATSProServer.Application.Messaging;
using ATSProServer.Domain.AppEntities;

namespace ATSProServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateStaticMainRoles;

public sealed record CreateStaticMainRolesCommand(
    List<MainRole>MainRoles) :ICommand<CreateStaticMainRolesResponse>;
