using ResumeAppApi.Application.BlogCategories.Dtos;

namespace ResumeAppApi.Application.BlogCategories.Queries.GetBlogCategoryById;

public class GetBlogCategoryByIdQueryHandler(IBlogArticleCategoryRepository blogArticleCategoryRepository,
	IMapper mapper) : IRequestHandler<GetBlogCategoryByIdQuery, BlogCategoryDto>
{
	public async Task<BlogCategoryDto?> Handle(GetBlogCategoryByIdQuery request, CancellationToken cancellationToken)
	{
		var category = await blogArticleCategoryRepository.GetBy(request.Id);

		if (category is null)
			return null;

		return mapper.Map<BlogCategoryDto>(category);
	}
}
