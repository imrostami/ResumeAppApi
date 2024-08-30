namespace ResumeAppApi.Application.BlogCategories.Commands.UpdateBlogCategory;

public class UpdateBlogCategoryCommand : IRequest<bool>
{
	public int CategoryId { get; set; }
	public string CategoryName { get; set; }
}
