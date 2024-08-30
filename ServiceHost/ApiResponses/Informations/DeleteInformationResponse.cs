using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.Informations
{
	public class DeleteInformationResponse(bool ok) : IResponse
	{
		public bool Ok => ok;

		public string Message => ok ? ResponseMessage.Deleted() :
			ResponseMessage.NotFound();
	}
}
