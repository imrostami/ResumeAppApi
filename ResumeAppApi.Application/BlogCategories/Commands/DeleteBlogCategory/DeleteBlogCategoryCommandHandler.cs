
namespace ResumeAppApi.Application.BlogCategories.Commands.DeleteBlogCategory;

public class DeleteBlogCategoryCommandHandler(IBlogArticleCategoryRepository blogArticleCategoryRepository) : IRequestHandler<DeleteBlogCategoryCommand, bool>
{
	public async Task<bool> Handle(DeleteBlogCategoryCommand request, CancellationToken cancellationToken)
	{
		var category = await blogArticleCategoryRepository.GetBy(request.Id);

		if (category is null)
			return false;

		await blogArticleCategoryRepository.DeleteAsync(category);
		return true;
	}
}
