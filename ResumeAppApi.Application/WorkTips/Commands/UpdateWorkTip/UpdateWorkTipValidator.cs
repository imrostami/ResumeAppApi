namespace ResumeAppApi.Application.WorkTips.Commands.UpdateWorkTip;

public class UpdateWorkTipValidator : AbstractValidator<UpdateWorkTipCommand>
{
	public UpdateWorkTipValidator()
	{
		RuleFor(x => x.Title)
			.NotEmpty()
			.WithMessage("عنوان وارد نشده");

		RuleFor(x => x.Caption)
			.NotEmpty()
			.WithMessage("توضیحات وارد نشده");

		
	}
}
