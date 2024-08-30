using ResumeAppApi.Application.BlogCategories.Dtos;
using ServiceHost.Responses;
using System.Text.Json.Serialization;

namespace ServiceHost.ApiResponses.Blogs
{
	public class GetBlogCategoryResponse(BlogCategoryDto blogCategory) : IResponse<BlogCategoryDto>
	{
		public bool Ok => blogCategory != null;

		
		public BlogCategoryDto Result => blogCategory;

		[JsonIgnore]
		public string Message => string.Empty;
	}
}
