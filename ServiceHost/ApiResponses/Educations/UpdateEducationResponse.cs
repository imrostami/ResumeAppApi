using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.Educations
{
	public class UpdateEducationResponse(bool ok) : IResponse
	{
		public bool Ok => ok;

		public string Message => ok ? ResponseMessage.Updated() :
			ResponseMessage.NotFound();
	}
}
