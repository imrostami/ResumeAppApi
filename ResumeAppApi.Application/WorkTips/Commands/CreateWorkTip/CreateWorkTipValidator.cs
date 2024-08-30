namespace ResumeAppApi.Application.WorkTips.Commands.CreateWorkTip;

public class CreateWorkTipValidator : AbstractValidator<CreateWorkTipCommand>
{
	public CreateWorkTipValidator()
	{
		RuleFor(x => x.Title)
			.NotEmpty()
			.WithMessage("عنوان وارد نشده");

		RuleFor(x => x.Caption)
			.NotEmpty()
			.WithMessage("توضیحات وارد نشده");

		RuleFor(x => x.Icon)
			.NotNull()
			.WithMessage("آیکون الزامی است");
	}
}
