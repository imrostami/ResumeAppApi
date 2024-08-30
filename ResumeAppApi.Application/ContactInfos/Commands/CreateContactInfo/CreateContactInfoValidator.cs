namespace ResumeAppApi.Application.ContactInfos.Commands.CreateContactInfo;

public class CreateContactInfoValidator : AbstractValidator<CreateContactInfoCommand>
{
	public CreateContactInfoValidator()
	{
		RuleFor(x => x.ContactName).NotEmpty()
			.WithMessage("نام نباید خالی باشد");

		RuleFor(x => x.ContactValue).NotEmpty()
			.WithMessage("مقدار نمیتواند خالی باشد");
	}
}
