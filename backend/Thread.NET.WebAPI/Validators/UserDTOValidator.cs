﻿using FluentValidation;
using Thread.NET.Common.DTO.User;

namespace Thread.NET.Validators
{
    public sealed class UserRegisterDTOValidator : AbstractValidator<UserRegisterDTO>
    {
        public UserRegisterDTOValidator()
        {
            RuleFor(u => u.UserName)
                .NotEmpty()
                    .WithMessage("Username is mandatory.")
                .MinimumLength(3)
                    .WithMessage("Username should be minimum 3 character.");

            RuleFor(u => u.Email)
                .EmailAddress();

            RuleFor(u => u.Password)
                .Length(4, 16)
                .WithMessage("Password must be from 4 to 16 characters.");
        }
    }
}
