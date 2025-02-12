namespace ResumeAppApi.Application.WorkSamples.Commands.CreateWorkSample;

public class CreateWorkSampleValidator : AbstractValidator<CreateWorkSampleCommand>
{
    public CreateWorkSampleValidator()
    {
        RuleFor(x=>x.Name).NotEmpty()
            .WithMessage("نام وارد نشده");

        RuleFor(x => x.Description).NotEmpty()
            .WithMessage("توضیحات وارد نشده");

        RuleFor(x => x.Icon)
            .NotEmpty()
            .WithMessage("لوگو الزامی است");

        RuleFor(x => x.ShortDescription)
            .NotEmpty()
            .WithMessage("توضیحات کوتاه الزامی است")
            .MaximumLength(200)
            .WithMessage("حداکثر مجاز 200 کاراکتر است");

        

    }
}
