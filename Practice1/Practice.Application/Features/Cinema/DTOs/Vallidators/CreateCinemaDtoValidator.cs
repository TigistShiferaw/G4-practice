using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Application.Features.Cinema.DTOs.Vallidators
{
    public class CreateCinemaDtoValidator: AbstractValidator<CreateCinemaDto>
    {
        public CreateCinemaDtoValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed {ComparisonValue} characters.");

            RuleFor(p => p.Location)
               .NotEmpty().WithMessage("{PropertyName} is required.")
               .NotNull()
               .MaximumLength(400).WithMessage("{PropertyName} must not exceed {ComparisonValue} characters.");


            RuleFor(p => p.ContactInformation)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(400).WithMessage("{PropertyName} must not exceed {ComparisonValue} characters.");

        }

    }
}
