using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.Blogs
{
	public class UpdateBlogImageResponse(bool ok) : IResponse
	{
		public bool Ok => ok;

		public string Message => ok ? ResponseMessage.Updated("تصویر") :
			ResponseMessage.NotFound();
	}
}
