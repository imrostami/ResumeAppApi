namespace ResumeAppApi.Application.WorkSampleCategories.Commands.UpdateWorkSampleCategory;

public class UpdateWorkSampleCategoryValidator : AbstractValidator<UpdateWorkSampleCategoryCommand>
{
    public UpdateWorkSampleCategoryValidator()
    {
        RuleFor(x => x.CategoryName)
            .NotEmpty()
            .WithMessage("نام دسته بندی وارد نشده");
    }
}
