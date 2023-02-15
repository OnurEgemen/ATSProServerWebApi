using ATSProServer.Application.Messaging;
using ATSProServer.Application.Service.AppServices;
using ATSProServer.Domain.AppEntities.Identity;

namespace ATSProServer.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole
{
    public class DeleteRoleCommandHandler : ICommandHandler<DeleteRoleCommand, DeleteRoleCommandResponse>
    {
        private readonly IRoleService _roleService;

        public DeleteRoleCommandHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<DeleteRoleCommandResponse> Handle(DeleteRoleCommand request, CancellationToken 
            cancellationToken)
        {
            AppRole role = await _roleService.GetById(request.Id);
            if (role == null) throw new Exception("Rol bulunamadı!");
            await _roleService.DeleteAsync(role);

            return new();
        }
    }
}
