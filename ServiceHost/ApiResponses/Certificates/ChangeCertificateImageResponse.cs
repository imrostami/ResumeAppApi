using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.Certificates
{
	public class ChangeCertificateImageResponse(bool ok) : IResponse
	{
		public bool Ok => ok;

		public string Message => ok ? ResponseMessage.Updated("تصویر گواهی") :
			ResponseMessage.NotFound("گواهی");
	}
}
