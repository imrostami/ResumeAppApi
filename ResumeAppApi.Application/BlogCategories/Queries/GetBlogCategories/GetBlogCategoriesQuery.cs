using ResumeAppApi.Application.BlogCategories.Dtos;

namespace ResumeAppApi.Application.BlogCategories.Queries.GetBlogCategories;

public class GetBlogCategoriesQuery : IRequest<IEnumerable<BlogCategoryDto>>
{
}
