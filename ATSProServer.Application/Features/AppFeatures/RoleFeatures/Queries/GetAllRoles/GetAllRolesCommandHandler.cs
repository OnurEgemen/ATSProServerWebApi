using ATSProServer.Application.Messaging;
using ATSProServer.Application.Service.AppServices;
using ATSProServer.Domain.AppEntities.Identity;
using MediatR;

namespace ATSProServer.Application.Features.AppFeatures.RoleFeatures.Queries.GetAllRoles
{
    public sealed class GetAllRolesCommandHandler : IQueryHandler<GetAllRolesCommand, GetAllRolesCommandResponse>
    {
        private readonly IRoleService _roleService;

        public GetAllRolesCommandHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<GetAllRolesCommandResponse> Handle(GetAllRolesCommand request, CancellationToken 
            cancellationToken)
        {
            IList<AppRole> roles = await _roleService.GetAllRolesAsync();
            return new GetAllRolesCommandResponse { Roles= roles };
        }
    }
}
