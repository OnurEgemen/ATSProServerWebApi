using FluentValidation;

namespace ATSProServer.Application.Features.AppFeatures.AppUserFeatures.Commands.Login
{
    public sealed class LoginCommandValidator : AbstractValidator<LoginCommand>
    {
        public LoginCommandValidator()
        {
            RuleFor(p => p.EmailOrUsername).NotEmpty().WithMessage("Mail veya kullanıcı adı yazmanız gerekmektedir!");
            RuleFor(p => p.EmailOrUsername).NotNull().WithMessage("Mail veya kullanıcı adı yazmanız gerekmektedir!");
            RuleFor(p => p.Password).NotEmpty().WithMessage("Şifre bilgisi boş olamaz!");
            RuleFor(p => p.Password).NotNull().WithMessage("Şifre bilgisi boş olamaz!");
            RuleFor(p => p.Password).MinimumLength(6).WithMessage("Şifre en az 6 karakter olmalıdır");
            RuleFor(p => p.Password).Matches("[A-Z]").WithMessage("Şifre en az 1 adet büyük harf içermelidir");
            RuleFor(p => p.Password).Matches("[a-z]").WithMessage("Şifre en az 1 adet küçük harf içermelidir");
            RuleFor(p => p.Password).Matches("[0-9]").WithMessage("Şifre en az 1 adet rakam içermelidir");
            RuleFor(p => p.Password).Matches("[^a-zA-Z0-9]").WithMessage("Şifre en az 1 adet özel karakter");
        }
    }
}
