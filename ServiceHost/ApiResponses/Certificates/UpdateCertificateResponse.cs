using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.Certificates
{
	public class UpdateCertificateResponse(bool ok) : IResponse
	{
		public bool Ok => ok;

		public string Message => ok ? ResponseMessage.Updated("گواهی") :
			ResponseMessage.NotFound("گواهی");
	}
}
