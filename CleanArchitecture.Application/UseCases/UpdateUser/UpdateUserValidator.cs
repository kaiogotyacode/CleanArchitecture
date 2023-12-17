using FluentValidation;

namespace CleanArchitecture.Application.UseCases.UpdateUser;

public class UpdateUserValidator : AbstractValidator<UpdateUserRequest>
{
    public UpdateUserValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
        RuleFor(x => x.Email).NotEmpty().MaximumLength(50).EmailAddress();
        RuleFor(x => x.Nome).NotEmpty().MaximumLength(50).MinimumLength(3);
    }
}
