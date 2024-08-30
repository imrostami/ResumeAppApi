using Microsoft.AspNetCore.Http;

namespace ResumeAppApi.Application.Certificates.Commands.ChangeCertificateImage;

public class ChangeCertificateImageCommand : IRequest<bool>
{
	public int CertificateId { get; set; }
    public IFormFile Image { get; set; }

}
