using ResumeAppApi.Application.Blogs.Dtos;

namespace ResumeAppApi.Application.Blogs.Queries.GetBlogs;

public class GetBlogsQueryHandler(IBlogArticleRepository blogArticleRepository,
	IMapper mapper) : IRequestHandler<GetBlogsQuery, IEnumerable<BlogDto>>
{
	public async Task<IEnumerable<BlogDto>> Handle(GetBlogsQuery request, CancellationToken cancellationToken)
	{
		var blogs = await blogArticleRepository.GetAll();
		return mapper.Map<IEnumerable<BlogDto>>(blogs);
	}
}
