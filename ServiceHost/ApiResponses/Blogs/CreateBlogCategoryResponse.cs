using ResumeAppApi.Application.BlogCategories.Dtos;
using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.Blogs
{
	public class CreateBlogCategoryResponse(BlogCategoryDto blogCategory) : IResponse<BlogCategoryDto>
	{
		public bool Ok => blogCategory != null;

		public BlogCategoryDto Result => blogCategory;

		public string Message => Ok ? ResponseMessage.Added() :
			ResponseMessage.Duplicate();
	}
}
