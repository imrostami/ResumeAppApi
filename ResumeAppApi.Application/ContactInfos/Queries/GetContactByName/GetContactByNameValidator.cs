namespace ResumeAppApi.Application.ContactInfos.Queries.GetContactByName;

public class GetContactByNameValidator : AbstractValidator<GetContactByNameQuery>
{
    public GetContactByNameValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage("نام نباید خالی باشد");
    }
}
