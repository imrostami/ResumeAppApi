using Microsoft.AspNetCore.Http;
using ResumeAppApi.Application.Certificates.Dtos;
using System.Text.Json.Serialization;

namespace ResumeAppApi.Application.Certificates.Commands.CreateCertificate;

public class CreateCertificateCommand : IRequest<CertificateDto>
{
	public string Name { get; set; }
	public string Caption { get; set; }
	public string Issuer { get; set; }
    public IFormFile? Image { get; set; }
    public string ImageAlt { get; set; }
    

}
