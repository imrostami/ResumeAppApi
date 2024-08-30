namespace ResumeAppApi.Application.Certificates.Commands.CreateCertificate
{
	public class CreateCertificateValidator : AbstractValidator<CreateCertificateCommand>
	{
        public CreateCertificateValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("نام گواهی الزامی است");

			RuleFor(x => x.Caption)
			   .NotEmpty()
			   .WithMessage("توضیحات گواهی الزامی است");

			RuleFor(x => x.Issuer)
			   .NotEmpty()
			   .WithMessage("نام صادرکننده گواهی الزامی است");

			RuleFor(x => x.ImageAlt)
				.NotEmpty()
				.WithMessage("alt عکس الزامی است");


			RuleFor(x => x.Image)
				.NotNull()
				.WithMessage("تصویر گواهی الزامی است");
		}
    }
}
