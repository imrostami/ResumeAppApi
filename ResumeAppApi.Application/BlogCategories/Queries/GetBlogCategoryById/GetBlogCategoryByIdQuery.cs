using ResumeAppApi.Application.BlogCategories.Dtos;

namespace ResumeAppApi.Application.BlogCategories.Queries.GetBlogCategoryById;

public class GetBlogCategoryByIdQuery : IRequest<BlogCategoryDto>
{
    public int Id { get; set; }
}
