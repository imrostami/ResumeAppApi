using ResumeAppApi.Application.BlogCategories.Dtos;

namespace ResumeAppApi.Application.BlogCategories.Queries.GetBlogCategories;

public class GetBlogCategoriesQueryHandler(IBlogArticleCategoryRepository blogArticleCategoryRepository,
	IMapper mapper) : IRequestHandler<GetBlogCategoriesQuery, IEnumerable<BlogCategoryDto>>
{
	public async Task<IEnumerable<BlogCategoryDto>> Handle(GetBlogCategoriesQuery request, CancellationToken cancellationToken)
	{
		var categories = await blogArticleCategoryRepository.GetAll();
		return mapper.Map<IEnumerable<BlogCategoryDto>>(categories);
		
	}
}
