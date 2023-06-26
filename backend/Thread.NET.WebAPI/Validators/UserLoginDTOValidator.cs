using FluentValidation;
using Thread.NET.Common.DTO.User;

namespace Thread.NET.Validators
{
    public sealed class UserLoginDTOValidator : AbstractValidator<UserLoginDTO>
    {
        public UserLoginDTOValidator()
        {
            RuleFor(u => u.Email).NotNull();
            RuleFor(u => u.Password).NotNull();
        }
    }
}
