using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.Blogs
{
	public class UpdateBlogResponse(bool ok) : IResponse
	{
		public bool Ok => ok;

		public string Message => ok ? ResponseMessage.Updated() :
			ResponseMessage.NotFound();
	}
}
