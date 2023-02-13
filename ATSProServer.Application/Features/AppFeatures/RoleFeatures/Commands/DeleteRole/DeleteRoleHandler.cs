﻿using ATSProServer.Application.Service.AppServices;
using ATSProServer.Domain.AppEntities.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace ATSProServer.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole
{
    public class DeleteRoleHandler : IRequestHandler<DeleteRoleRequest, DeleteRoleResponse>
    {
        private readonly IRoleService _roleService;

        public DeleteRoleHandler(IRoleService roleService)
        {
            _roleService = roleService;
        }

        public async Task<DeleteRoleResponse> Handle(DeleteRoleRequest request, CancellationToken 
            cancellationToken)
        {
            AppRole role = await _roleService.GetById(request.Id);
            if (role == null) throw new Exception("Rol bulunamadı!");
            await _roleService.DeleteAsync(role);

            return new();
        }
    }
}
