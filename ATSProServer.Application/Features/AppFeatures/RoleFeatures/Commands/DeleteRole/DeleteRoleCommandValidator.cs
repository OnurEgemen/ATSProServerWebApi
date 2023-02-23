using FluentValidation;

namespace ATSProServer.Application.Features.AppFeatures.RoleFeatures.Commands.DeleteRole
{
    public sealed class DeleteRoleCommandValidator : AbstractValidator<DeleteRoleCommand>
    {
        public DeleteRoleCommandValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Rol id bilgisi boş olamaz!");
            RuleFor(x => x.Id).NotNull().WithMessage("Rol id bilgisi boş olamaz!");
        }
    }
}
