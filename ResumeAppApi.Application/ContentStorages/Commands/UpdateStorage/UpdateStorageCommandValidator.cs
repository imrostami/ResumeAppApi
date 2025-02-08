namespace ResumeAppApi.Application.ContentStorages.Commands.UpdateStorage;

public class UpdateStorageCommandValidator : AbstractValidator<UpdateStorageCommand>
{
	public UpdateStorageCommandValidator()
	{
		RuleFor(x => x.Content)
			.NotEmpty()
			.WithMessage("محتوا الزامی است")
			.NotNull()
			.WithMessage("محتوا الزامی است");

		
	}
}
