namespace ResumeAppApi.Application.WorkSamples.Commands.ChangeWorkSampleImage
{
	public class ChangeWorkSampleValidator : AbstractValidator<ChangeWorkSampleImageCommand>
	{
        public ChangeWorkSampleValidator()
			=> RuleFor(x => x.Image).NotNull()
				.WithMessage("تصویر الزامی است");
	}
}
