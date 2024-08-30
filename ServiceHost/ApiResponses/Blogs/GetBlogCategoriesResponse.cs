using ResumeAppApi.Application.BlogCategories.Dtos;
using ServiceHost.Responses;
using System.Text.Json.Serialization;

namespace ServiceHost.ApiResponses.Blogs
{
	public class GetBlogCategoriesResponse(IEnumerable<BlogCategoryDto> blogCategories) : IResponse<IEnumerable<BlogCategoryDto>>
	{
		public bool Ok => blogCategories != null;

		public IEnumerable<BlogCategoryDto> Result => blogCategories;

		[JsonIgnore]
		public string Message => string.Empty;
	}
}
