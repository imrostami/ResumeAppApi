using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.Informations
{
	public class UpdateInformationResponse(bool ok) : IResponse
	{
		public bool Ok => ok;

		public string Message => ok ? ResponseMessage.Updated() :
			ResponseMessage.NotFound();
	}
}
