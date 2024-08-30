
namespace ResumeAppApi.Application.BlogCategories.Commands.UpdateBlogCategory;

internal class UpdateBlogCategoryCommandHandler(IBlogArticleCategoryRepository blogArticleCategoryRepository,
	IMapper mapper) : IRequestHandler<UpdateBlogCategoryCommand, bool>
{
	public async Task<bool> Handle(UpdateBlogCategoryCommand request, CancellationToken cancellationToken)
	{
		var blogCategory = await blogArticleCategoryRepository.GetBy(request.CategoryId);

		if (blogCategory is null)
			return false;

		var mappedCategory = mapper.Map(request, blogCategory);

		await blogArticleCategoryRepository.UpdateAsync(mappedCategory);

		return true;
	}
}
