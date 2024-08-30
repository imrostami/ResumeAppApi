namespace ResumeAppApi.Application.Certificates.Commands.UpdateCertificate;

public class UpdateCertificateValidator : AbstractValidator<UpdateCertificateCommand>
{
    public UpdateCertificateValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty()
            .WithMessage("نام گواهی الزامی است");

		RuleFor(x => x.Caption)
		   .NotEmpty()
		   .WithMessage("توضیحات گواهی الزامی است");

		RuleFor(x => x.Issuer)
		   .NotEmpty()
		   .WithMessage("نام صادر کننده گواهی الزامی است");

		RuleFor(x => x.ImageAlt)
		   .NotEmpty()
		   .WithMessage("alt عکس الزامی است");
	}
}
