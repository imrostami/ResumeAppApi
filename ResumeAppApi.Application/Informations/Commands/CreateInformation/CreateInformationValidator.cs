﻿namespace ResumeAppApi.Application.Informations.Commands.CreateInformation;

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

        RuleFor(x => x.PictureAlt)
            .NotEmpty()
            .WithMessage("alt عکس الزامی است");

        RuleFor(x => x.Birthday)
            .NotEmpty()
            .WithMessage("تاریخ وارد نشده");

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
