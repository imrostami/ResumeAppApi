using ResumeAppApi.Application.BlogCategories.Commands.UpdateBlogCategory;

namespace ResumeAppApi.Application.BlogCategories.Commands.UpdateBlogCategory;

public class UpdateBlogCategoryValidator : AbstractValidator<UpdateBlogCategoryCommand>
{
    public UpdateBlogCategoryValidator()
    {
        RuleFor(x => x.CategoryName)
            .NotEmpty()
            .WithMessage("نام دسته بندی الزامی است");
    }
}
