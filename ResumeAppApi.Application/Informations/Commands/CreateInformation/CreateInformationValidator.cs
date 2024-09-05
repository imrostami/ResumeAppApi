namespace ResumeAppApi.Application.Informations.Commands.CreateInformation;

public class CreateInformationValidator : AbstractValidator<CreateInformationCommand>
{
    public CreateInformationValidator()
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

        RuleFor(x => x.Birthday)
            .NotEmpty()
            .WithMessage("تاریخ وارد نشده")
            .Matches("^(\\d{4})\\/(0?[1-9]|1[012])\\/(0?[1-9]|[12][0-9]|3[01])$")
            .WithMessage("تاریخ باید با فرمت XXXX/XX/XX باشد");

        RuleFor(x => x.ShortAbout)
            .NotEmpty()
            .WithMessage("توضیحات کوتاه وارد نشده");


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
