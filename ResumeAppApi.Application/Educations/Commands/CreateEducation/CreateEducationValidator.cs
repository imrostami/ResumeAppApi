namespace ResumeAppApi.Application.Educations.Commands.CreateEducation;

public class CreateEducationValidator : AbstractValidator<CreateEducationCommand>
{
    public CreateEducationValidator()
    {
        string dateRegex = @"^[1-4]\d{3}\/((0[1-6]\/((3[0-1])|([1-2][0-9])|(0[1-9])))|((1[0-2]|(0[7-9]))\/(30|31|([1-2][0-9])|(0[1-9]))))$";

        RuleFor(x=>x.Title).NotEmpty()
            .WithMessage("عنوان نمی تواند خالی باشد");

        RuleFor(x => x.University)
            .NotEmpty()
            .WithMessage("نام موسسه نمی تواند خالی باشد");

        RuleFor(x => x.Description)
            .NotEmpty()
            .WithMessage("توضیحات نمی تواند خالی باشد");

        RuleFor(x => x.StartDate)
            .NotEmpty()
            .WithMessage("تاریخ شروع وارد نشده")
            .Matches(dateRegex)
            .WithMessage("تاریخ باید با فرمت XXXX/XX/XX باشد");

        RuleFor(x => x.EndDate)
            .NotEmpty()
            .WithMessage("تاریخ پایان وارد نشده")
			.Matches(dateRegex)
			.WithMessage("تاریخ باید با فرمت XXXX/XX/XX باشد"); ;


    }
}
