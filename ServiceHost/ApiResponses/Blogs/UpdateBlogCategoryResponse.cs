using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.Blogs
{
	public class UpdateBlogCategoryResponse(bool ok) : IResponse
	{
		public bool Ok => ok;

		public string Message => ok ? ResponseMessage.Updated() :
			ResponseMessage.NotFound();
	}
}
