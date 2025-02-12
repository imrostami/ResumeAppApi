namespace ResumeAppApi.Application.WorkSamples.Commands.UpdateWorkSample;

public class UpdateWorkSampleValidator : AbstractValidator<UpdateWorkSampleCommand>
{
    public UpdateWorkSampleValidator()
    {
		RuleFor(x => x.Name).NotEmpty()
		   .WithMessage("نام وارد نشده");

		RuleFor(x => x.Description).NotEmpty()
			.WithMessage("توضیحات وارد نشده");

		RuleFor(x => x.ShortDescription)
		   .NotEmpty()
		   .WithMessage("توضیحات کوتاه الزامی است")
		   .MaximumLength(200)
		   .WithMessage("حداکثر مجاز 200 کاراکتر است");
	}
}
