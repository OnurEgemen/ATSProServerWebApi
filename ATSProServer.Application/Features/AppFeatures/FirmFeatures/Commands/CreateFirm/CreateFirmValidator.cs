using FluentValidation;

namespace ATSProServer.Application.Features.AppFeatures.FirmFeatures.Commands.CreateFirm
{
    public sealed class CreateFirmValidator : AbstractValidator<CreateFirmCommand>
    {
        public CreateFirmValidator()
        {
            RuleFor(x => x.DatabaseName).NotEmpty().WithMessage("Veritabanı bilgisi yazılmalıdır!");
            RuleFor(x => x.DatabaseName).NotNull().WithMessage("Veritabanı bilgisi yazılmalıdır!");
            RuleFor(x => x.ServerName).NotEmpty().WithMessage("Server bilgisi yazılmalıdır!");
            RuleFor(x => x.ServerName).NotNull().WithMessage("Server bilgisi yazılmalıdır!");
            RuleFor(x => x.FirmName).NotEmpty().WithMessage("Şirket adı yazılmalıdır!");
            RuleFor(x => x.FirmName).NotNull().WithMessage("Şirket adı yazılmalıdır!");


        }
    }
}
