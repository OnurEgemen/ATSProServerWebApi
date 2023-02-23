using FluentValidation;

namespace ATSProServer.Application.Features.AppFeatures.RoleFeatures.Commands.UpdateRole
{
    public sealed class RoleUpdateCommandValidator : AbstractValidator<UpdateRoleCommand>
    {
        public RoleUpdateCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Rol id bilgisi boş olamaz!");
            RuleFor(x => x.Id).NotNull().WithMessage("Rol id bilgisi boş olamaz!");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Rol adı boş olamaz!");
            RuleFor(x => x.Name).NotNull().WithMessage("Rol adı boş olamaz!");
            RuleFor(x => x.Code).NotEmpty().WithMessage("Rol kodu boş olamaz!");
            RuleFor(x => x.Code).NotNull().WithMessage("Rol kodu boş olamaz!");
        }
    }
}
