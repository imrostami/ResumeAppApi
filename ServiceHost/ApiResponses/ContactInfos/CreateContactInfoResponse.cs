using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.ContactInfos
{
	public class CreateContactInfoResponse(bool ok) : IResponse
	{
		public bool Ok => ok;

		public string Message 
			=> ok ? ResponseMessage.Added():
			ResponseMessage.Duplicate();
	}
}
