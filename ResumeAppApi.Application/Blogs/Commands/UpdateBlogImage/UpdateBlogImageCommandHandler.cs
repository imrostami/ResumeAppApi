namespace ResumeAppApi.Application.Blogs.Commands.UpdateBlogImage;

public class UpdateBlogImageCommandHandler(IBlogArticleRepository blogArticleRepository,
	IFileUploader fileUploader) : IRequestHandler<UpdateBlogImageCommand, bool>
{
	public async Task<bool> Handle(UpdateBlogImageCommand request, CancellationToken cancellationToken)
	{
		var article = await blogArticleRepository.GetBy(request.Id);

		if (article is null)
			return false;


		var uploadBlogImageResult = await fileUploader.UploadDefault(request.Picture, AppDirectories.Images, "BlogImages");

		article.Picture = uploadBlogImageResult;
		await blogArticleRepository.UpdateAsync(article);
		return true;

	}
}
