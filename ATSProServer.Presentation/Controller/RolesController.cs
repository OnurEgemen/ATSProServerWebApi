using ATSProServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateAllRoles;
using ATSProServer.Application.Features.AppFeatures.RoleFeatures.Commands.CreateRole;
using ATSProServer.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole;
using ATSProServer.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole;
using ATSProServer.Application.Features.AppFeatures.RoleFeatures.Queries.GetAllRoles;
using ATSProServer.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ATSProServer.Presentation.Controller
{
    public class RolesController : ApiController
    {
        public RolesController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateRole(CreateRoleCommand request)
        {
            CreateRoleCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet ("[action]")]
        public async Task<IActionResult> GetAllRoles()
        {
            GetAllRolesCommand request = new();
            GetAllRolesCommandResponse response= await _mediator.Send(request); 
            return Ok(response);
        }

        [HttpPost ("[action]")]

        public async Task<IActionResult> UpdateRole(UpdateRoleCommand request)
        {
            UpdateRoleCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]/{id}")]
        
        public async Task<IActionResult> DeleteRole(string id)
        {
            DeleteRoleCommand request = new(id);
            

            DeleteRoleCommandResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> CreateAllRoles()
        {
            CreateAllRolesCommand request = new();
            CreateAllRolesCommandResponse response= await _mediator.Send(request);
            return Ok(response);
        }

    }
}
