using ResumeAppApi.Application.Blogs.Dtos;
using ResumeAppApi.Domain.Entities.BlogAgg;

namespace ResumeAppApi.Application.Blogs.Commands.CreateBlog;

public class CreateBlogCommandHandler(IBlogArticleRepository blogArticleRepository,
	IMapper mapper , IFileUploader fileUploader) : IRequestHandler<CreateBlogCommand, BlogDto>
{
	public async Task<BlogDto> Handle(CreateBlogCommand request, CancellationToken cancellationToken)
	{
		var blog = mapper.Map<BlogArticle>(request);
		var blogPicutreUploadResult = await fileUploader.UploadDefault(request.Picture,AppDirectories.Images,"BlogImages");
		blog.Picture = blogPicutreUploadResult;

		var createBlogResult = await blogArticleRepository.CreateAsync(blog);


		return mapper.Map<BlogDto>(createBlogResult);


	}
}
