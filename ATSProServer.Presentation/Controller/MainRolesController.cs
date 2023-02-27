using ATSProServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateMainRole;
using ATSProServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateRole;
using ATSProServer.Application.Features.AppFeatures.MainRoleFeatures.Commands.CreateStaticMainRoles;
using ATSProServer.Presentation.Abstraction;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ATSProServer.Presentation.Controller;

public sealed class MainRolesController : ApiController
{
    public MainRolesController(IMediator mediator) : base(mediator)
    {
    }


    [HttpPost("[action]")]
    public async Task<IActionResult>CreateMainRole(CreateMainRoleCommand request, CancellationToken
        cancellationToken)
    {
        CreateMainRoleResponse response = await _mediator.Send(request,cancellationToken);
        return Ok(response);

    }

    [HttpPost("[action]")]
    public async Task<IActionResult> CreateStaticMainRoles(CreateStaticMainRolesCommand request, 
        CancellationToken cancellationToken)
    {
        CreateStaticMainRolesResponse response = await _mediator.Send(request, cancellationToken);
        return Ok(response);

    }

}
