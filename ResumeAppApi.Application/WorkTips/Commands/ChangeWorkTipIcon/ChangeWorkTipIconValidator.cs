namespace ResumeAppApi.Application.WorkTips.Commands.ChangeWorkTipIcon
{
	public class ChangeWorkTipIconValidator : AbstractValidator<ChangeWorkTipIconCommand>
	{
        public ChangeWorkTipIconValidator()
        {
            RuleFor(x => x.Icon)
                .NotNull()
                .WithMessage("آیکون نمیتواند خالی باشد");
        }
    }
}
