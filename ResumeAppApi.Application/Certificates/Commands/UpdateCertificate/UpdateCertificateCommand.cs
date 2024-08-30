using Microsoft.AspNetCore.Http;

namespace ResumeAppApi.Application.Certificates.Commands.UpdateCertificate;

public class UpdateCertificateCommand : IRequest<bool>
{
	public int CertificateId { get; set; }
	public string Name { get; set; }
	public string Caption { get; set; }
	public string Issuer { get; set; }
	public string ImageAlt { get; set; }
}
