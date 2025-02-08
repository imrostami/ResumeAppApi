namespace ResumeAppApi.Application.ContentStorages.Commands.CreateStorage;

public class CreateStorageCommandValidator : AbstractValidator<CreateStorageCommand>
{
	public CreateStorageCommandValidator()
	{
		RuleFor(x => x.Name)
			.NotEmpty()
			.WithMessage("نام الزامی است")
			.NotNull()
			.WithMessage("نام الزامی است");

		RuleFor(x => x.Content)
			.NotEmpty()
			.WithMessage("مقدار الزامی است")
			.NotNull()
			.WithMessage("مقدار الزامی است");
	}
}
