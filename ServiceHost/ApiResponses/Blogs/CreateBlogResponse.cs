using ResumeAppApi.Application.Blogs.Dtos;
using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.Blogs
{
	public class CreateBlogResponse(BlogDto? blogPost) : IResponse<BlogDto>
	{
		public bool Ok => blogPost != null;

		public BlogDto Result => blogPost;

		public string Message => Ok ? ResponseMessage.Added() :
			ResponseMessage.Duplicate();
	}
}
