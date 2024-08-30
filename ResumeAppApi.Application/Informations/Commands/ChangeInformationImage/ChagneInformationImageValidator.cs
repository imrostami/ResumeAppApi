namespace ResumeAppApi.Application.Informations.Commands.ChangeInformationImage;

public class ChagneInformationImageValidator : AbstractValidator<ChangeInformationImageCommand>
{
    public ChagneInformationImageValidator()
    {
		RuleFor(x => x.Image)
		   .NotEmpty()
		   .WithMessage("عکس نباید خالی باشد");

		RuleFor(x => x.PictureAlt)
			.NotEmpty()
			.WithMessage("alt عکس الزامی است");
	}
}
