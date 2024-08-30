using ResumeAppApi.Application.Blogs.Dtos;
using ServiceHost.Responses;
using System.Text.Json.Serialization;

namespace ServiceHost.ApiResponses.Blogs
{
	public class GetBlogResponse(BlogDto blog) : IResponse<BlogDto>
	{
		public bool Ok => blog != null;

		public BlogDto Result => blog;

		[JsonIgnore]
		public string Message => string.Empty;
	}
}
