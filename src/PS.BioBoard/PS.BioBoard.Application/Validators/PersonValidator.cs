using FluentValidation;
using PS.BioBoard.Domain.Entities;

namespace PS.BioBoard.Application.Validators
{
    public class PersonValidator : AbstractValidator<Person>
    {
        public PersonValidator()
        {
            RuleFor(person => person.Name)
                .NotEmpty().WithMessage("Name is required.")
                .MaximumLength(50).WithMessage("Name must be less than 50 characters.");

            RuleFor(person => person.Bio)
                .MaximumLength(500).WithMessage("Bio must be less than 500 characters.");

            RuleFor(person => person.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Email must be a valid email address.");

            RuleFor(person => person.PhoneNumber)
                .NotEmpty().WithMessage("Phone number is required.")
                .Matches(@"^\+?\d{8,13}$").WithMessage("Phone number must be a valid format.");

            RuleFor(person => person.ImageUrl)
                .NotEmpty().WithMessage("Image URL is required.")
                .Must(uri => Uri.IsWellFormedUriString(uri, UriKind.Absolute)).WithMessage("Image URL must be a valid URL.");
        }
    }
}


