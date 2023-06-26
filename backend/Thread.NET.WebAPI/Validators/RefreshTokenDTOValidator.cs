using FluentValidation;
using Thread.NET.Common.DTO.Auth;

namespace Thread.NET.Validators
{
    public sealed class RefreshTokenDTOValidator : AbstractValidator<RefreshTokenDTO>
    {
        public RefreshTokenDTOValidator()
        {
            RuleFor(x => x.RefreshToken)
                .NotEmpty()
                .WithMessage("Refresh token can not be empty.");

            RuleFor(x => x.AccessToken)
                .NotEmpty()
                .WithMessage("Access token can not be empty.");
        }
    }
}
