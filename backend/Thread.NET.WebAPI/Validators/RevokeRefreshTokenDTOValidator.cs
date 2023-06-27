using FluentValidation;
using Thread.NET.Common.DTO.Auth;

namespace Thread.NET.Validators
{
    public sealed class RevokeRefreshTokenDTOValidator : AbstractValidator<RevokeRefreshTokenDTO>
    {
        public RevokeRefreshTokenDTOValidator()
        {
            RuleFor(r => r.RefreshToken)
                .NotEmpty()
                .WithMessage("Refresh token can not be empty.");
        }
    }
}
