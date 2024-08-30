using ResumeAppApi.Application.Blogs.Dtos;

namespace ResumeAppApi.Application.Blogs.Queries.GetBlogById
{
	public class GetBlogByIdQueryHandler(IBlogArticleRepository blogArticleRepository,
		IMapper mapper) : IRequestHandler<GetBlogByIdQuery, BlogDto>
	{
		public async Task<BlogDto?> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
		{
			var blog = await blogArticleRepository.GetBy(request.Id);

			if (blog is null)
				return null;

			return mapper.Map<BlogDto>(blog);
		}
	}
}
