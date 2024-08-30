using ResumeAppApi.Application.BlogCategories.Dtos;

namespace ResumeAppApi.Application.BlogCategories.Commands.CreateBlogCategory;

public class CreateBlogCategoryCommand : IRequest<BlogCategoryDto>
{
	public string CategoryName { get; set; }
}
