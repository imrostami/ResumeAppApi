using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using ResumeAppApi.Application.BlogCategories.Dtos;

namespace ResumeAppApi.Application.BlogCategories.Queries.GetBlogCategories;

public class GetBlogCategoriesQueryHandler(IBlogArticleCategoryRepository blogArticleCategoryRepository,
	IMapper mapper) : IRequestHandler<GetBlogCategoriesQuery, IEnumerable<BlogCategoryDto>>
{
	public async Task<IEnumerable<BlogCategoryDto>> Handle(GetBlogCategoriesQuery request, CancellationToken cancellationToken)
		=> await blogArticleCategoryRepository.Query()
		.ProjectTo<BlogCategoryDto>(mapper.ConfigurationProvider)
		.ToListAsync();
}
