namespace ResumeAppApi.Application.WorkSampleCategories.Commands.CreateWorkSampleCategory;

public class CreateWorkSampleCategoryValidator : AbstractValidator<CreateWorkSampleCategoryCommand>
{
    public CreateWorkSampleCategoryValidator()
    {
        RuleFor(x => x.CategoryName)
            .NotEmpty()
            .WithMessage("نام دسته بندی وارد نشده");
    }
}
