using FluentValidation;

namespace ATSProServer.Application.Features.FirmFeatures.CarFeatures.Commands.CreateCar
{
    public sealed class CreateCarCommandValidator : AbstractValidator<CreateCarCommand>
    {
        public CreateCarCommandValidator()
        {
            RuleFor(x=>x.CarId).NotEmpty().WithMessage("Araç id bilgisi boş bırakılamaz!");
            RuleFor(x=>x.CarId).NotNull().WithMessage("Araç id bilgisi boş bırakılamaz!");
            RuleFor(x => x.FirmId).NotEmpty().WithMessage("Firma id bilgisi boş bırakılamaz!");
            RuleFor(x => x.FirmId).NotNull().WithMessage("Firma id bilgisi boş bırakılamaz!");
            RuleFor(x => x.CarBrand).NotEmpty().WithMessage("Araç marka bilgisi boş bırakılamaz!");
            RuleFor(x => x.CarBrand).NotNull().WithMessage("Araç marka bilgisi boş bırakılamaz!");
            RuleFor(x => x.CarModel).NotEmpty().WithMessage("Araç model bilgisi boş bırakılamaz!");
            RuleFor(x => x.CarModel).NotNull().WithMessage("Araç model bilgisi boş bırakılamaz!");
            
        }
    }
}
