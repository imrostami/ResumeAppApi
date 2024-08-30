namespace ResumeAppApi.Application.WorkSamples.Commands.ChangeWorkSampleImage
{
	public class ChangeWorkSampleValidator : AbstractValidator<ChangeWorkSampleImageCommand>
	{
        public ChangeWorkSampleValidator()
		{
			RuleFor(x => x.Image)
		   .NotEmpty()
		   .WithMessage("عکس نباید خالی باشد");

			RuleFor(x => x.PictureAlt)
				.NotEmpty()
				.WithMessage("alt عکس الزامی است");
		}
	}
}
