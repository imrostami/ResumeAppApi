namespace ResumeAppApi.Application.WorkSamples.Commands.UpdateWorkSample;

public class UpdateWorkSampleValidator : AbstractValidator<UpdateWorkSampleCommand>
{
    public UpdateWorkSampleValidator()
    {
		RuleFor(x => x.Name).NotEmpty()
		   .WithMessage("نام وارد نشده");

		RuleFor(x => x.Description).NotEmpty()
			.WithMessage("توضیحات وارد نشده");
	}
}
