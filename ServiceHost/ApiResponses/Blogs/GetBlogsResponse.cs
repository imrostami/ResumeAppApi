using ResumeAppApi.Application.Blogs.Dtos;
using ServiceHost.Responses;
using System.Text.Json.Serialization;

namespace ServiceHost.ApiResponses.Blogs
{
	public class GetBlogsResponse(IEnumerable<BlogDto> blogs) : IResponse<IEnumerable<BlogDto>>
	{
		public bool Ok => blogs != null;

		public IEnumerable<BlogDto> Result => blogs;

		[JsonIgnore]
		public string Message => string.Empty;
	}
}
