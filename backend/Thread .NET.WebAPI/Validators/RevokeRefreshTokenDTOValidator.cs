using FluentValidation;
using Thread_.NET.Common.DTO.Auth;

namespace Thread_.NET.Validators
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
