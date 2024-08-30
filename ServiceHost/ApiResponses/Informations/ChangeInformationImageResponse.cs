using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.Informations
{
	public class ChangeInformationImageResponse(bool ok) : IResponse
	{
		public bool Ok => ok;

		public string Message => ok ? ResponseMessage.Updated("تصویر") :
			ResponseMessage.NotFound();
	}
}
