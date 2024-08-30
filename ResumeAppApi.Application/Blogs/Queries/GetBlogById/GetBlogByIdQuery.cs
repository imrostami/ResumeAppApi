using ResumeAppApi.Application.Blogs.Dtos;

namespace ResumeAppApi.Application.Blogs.Queries.GetBlogById
{
	public class GetBlogByIdQuery : IRequest<BlogDto>
	{
        public int Id { get; set; }
    }
}
