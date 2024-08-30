using ResumeAppApi.Application.Certificates.Dtos;
using ServiceHost.Responses;
using System.Text.Json.Serialization;

namespace ServiceHost.ApiResponses.Certificates
{
	public class GetCertificatesResponse(IEnumerable<CertificateDto> certificates) : IResponse<IEnumerable<CertificateDto>>
	{
		public bool Ok => Result != null;

		public IEnumerable<CertificateDto> Result => certificates;

		[JsonIgnore]
		public string Message => string.Empty;
	}
}
