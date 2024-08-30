using ResumeAppApi.Application.Certificates.Dtos;
using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.Certificates
{
	public class CreateCertificateResponse(CertificateDto certificate) : IResponse
	{
		public bool Ok => certificate != null;

		public CertificateDto Result => certificate;

		public string Message => Ok ? ResponseMessage.Added() :
			ResponseMessage.Broken();
	}
}
