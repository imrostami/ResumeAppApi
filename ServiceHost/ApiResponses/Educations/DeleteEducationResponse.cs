using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.Educations
{
	public class DeleteEducationResponse(bool ok) : IResponse
	{
		public bool Ok => ok;

		public string Message => ok ? ResponseMessage.Deleted() :
			ResponseMessage.NotFound();
	}
}
