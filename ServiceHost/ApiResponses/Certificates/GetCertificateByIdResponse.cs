using ResumeAppApi.Application.Certificates.Dtos;
using ServiceHost.Responses;
using System.Text.Json.Serialization;

namespace ServiceHost.ApiResponses.Certificates
{
	public class GetCertificateByIdResponse(CertificateDto? certificate) : IResponse<CertificateDto>
	{
		public bool Ok => Result != null;

		public CertificateDto? Result => certificate;

		[JsonIgnore]
		public string Message => string.Empty;
	}
}
