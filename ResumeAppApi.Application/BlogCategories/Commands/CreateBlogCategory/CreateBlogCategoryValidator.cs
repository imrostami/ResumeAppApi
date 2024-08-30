namespace ResumeAppApi.Application.BlogCategories.Commands.CreateBlogCategory;

public class UpdateBlogCategoryValidator : AbstractValidator<CreateBlogCategoryCommand>
{
    public UpdateBlogCategoryValidator()
    {
        RuleFor(x => x.CategoryName)
            .NotEmpty()
            .WithMessage("نام دسته بندی الزامی است");
    }
}
