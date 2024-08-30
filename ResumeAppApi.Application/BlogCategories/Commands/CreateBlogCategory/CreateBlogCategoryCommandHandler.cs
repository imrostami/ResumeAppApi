using ResumeAppApi.Application.BlogCategories.Dtos;
using ResumeAppApi.Domain.Entities.BlogAgg;

namespace ResumeAppApi.Application.BlogCategories.Commands.CreateBlogCategory;

public class CreateBlogCategoryCommandHandler(IBlogArticleCategoryRepository blogArticleCategoryRepository,
	IMapper mapper) : IRequestHandler<CreateBlogCategoryCommand, BlogCategoryDto>
{
	public async Task<BlogCategoryDto?> Handle(CreateBlogCategoryCommand request, CancellationToken cancellationToken)
	{
		var dbCategory = blogArticleCategoryRepository.GetBy(request.CategoryName);
		if (dbCategory is not null)
			return null;

		var category = mapper.Map<BlogArticleCategory>(request);
		var createBlogCategoryResult = await blogArticleCategoryRepository.CreateAsync(category);

		return mapper.Map<BlogCategoryDto>(createBlogCategoryResult);
	}
}
