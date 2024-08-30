namespace ResumeAppApi.Application.BlogCategories.Commands.DeleteBlogCategory;

public class DeleteBlogCategoryCommand : IRequest<bool>
{
    public int Id { get; set; }
}
