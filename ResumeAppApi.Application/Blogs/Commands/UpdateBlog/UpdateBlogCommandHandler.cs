
namespace ResumeAppApi.Application.Blogs.Commands.UpdateBlog;

public class UpdateBlogCommandHandler(IBlogArticleRepository blogArticleRepository,
	IMapper mapper) : IRequestHandler<UpdateBlogCommand, bool>
{
	public async Task<bool> Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
	{
		var article = await blogArticleRepository.GetBy(request.Id);

		if (article is null)
			return false;



		var mappedArticle = mapper.Map(request,article);

		await blogArticleRepository.UpdateAsync(mappedArticle);
		
		return true;

	}
}
