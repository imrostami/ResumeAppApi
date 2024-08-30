using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.ContactInfos
{
	public class RemoveContactInfoResponse(bool ok) : IResponse
	{
		public bool Ok => ok;

		public string Message 
			=> ok ? ResponseMessage.Deleted() :
			ResponseMessage.NotFound();
	}
}
