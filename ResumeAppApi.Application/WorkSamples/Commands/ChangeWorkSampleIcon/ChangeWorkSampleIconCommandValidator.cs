namespace ResumeAppApi.Application.WorkSamples.Commands.ChangeWorkSampleIcon;

public class ChangeWorkSampleIconCommandValidator : AbstractValidator<ChangeWorkSampleIconCommand>
{
	public ChangeWorkSampleIconCommandValidator()
	{
		RuleFor(x => x.Icon)
			.NotEmpty()
			.WithMessage("icon الزامی است");
	}
}
