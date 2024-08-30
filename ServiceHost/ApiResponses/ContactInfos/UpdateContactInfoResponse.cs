using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.ContactInfos
{
	public class UpdateContactInfoResponse(bool ok) : IResponse
	{
		public bool Ok => ok;

		public string Message 
			=> ok ? ResponseMessage.Updated() :
			ResponseMessage.NotFound();
	}
}
