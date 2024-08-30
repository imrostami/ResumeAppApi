using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.Certificates
{
	public class DeleteCertificateResponse(bool ok) : IResponse
	{
		public bool Ok => ok;

		public string Message => ok ? ResponseMessage.Deleted("گواهی") :
			ResponseMessage.NotFound("گواهی");
	}
}
