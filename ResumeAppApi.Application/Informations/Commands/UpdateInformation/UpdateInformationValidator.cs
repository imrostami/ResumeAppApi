namespace ResumeAppApi.Application.Informations.Commands.UpdateInformation;

public class UpdateInformationValidator : AbstractValidator<UpdateInformationCommand>
{
    public UpdateInformationValidator()
    {
		RuleFor(x => x.FirstName)
		   .NotEmpty()
		   .WithMessage("نام وارد نشده");

		RuleFor(x => x.LastName)
			.NotEmpty()
			.WithMessage("نام خانوادگی وارد نشده");

		RuleFor(x => x.About)
			.NotEmpty()
			.WithMessage("بیوگرافی وارد نشده");

		RuleFor(x => x.PictureAlt)
			.NotEmpty()
			.WithMessage("alt عکس الزامی است");

		RuleFor(x => x.Birthday)
			.NotEmpty()
			.WithMessage("تاریخ وارد نشده");


		RuleFor(x => x.Languages)
			.NotEmpty()
			.WithMessage("زبان وارد نشده")
			.Matches("(.+?)(?:,|$)")
			.WithMessage("لطفا با پترن -,-,-,-,-  وارد کن");


		RuleFor(x => x.Nationality)
			.NotEmpty()
			.WithMessage("ملیت وارد نشده");
	}
}
