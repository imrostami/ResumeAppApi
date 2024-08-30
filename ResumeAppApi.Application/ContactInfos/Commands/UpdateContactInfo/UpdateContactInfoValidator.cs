namespace ResumeAppApi.Application.ContactInfos.Commands.UpdateContactInfo;

public class UpdateContactInfoValidator : AbstractValidator<UpdateContactInfoCommand>
{
    public UpdateContactInfoValidator()
    {
		RuleFor(x => x.ContactValue).NotEmpty()
			.WithMessage("مقدار نمیتواند خالی باشد");
	}
}
