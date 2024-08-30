
using ResumeAppApi.Application.Certificates.Dtos;
using ServiceHost.FileUploader;

namespace ResumeAppApi.Application.Certificates.Commands.CreateCertificate;

public class CreateCertificateCommandHandler(ICertificateRepository certificateRepository,
	IMapper mapper,IFileUploader fileUploader) : IRequestHandler<CreateCertificateCommand, CertificateDto>
{
	public async Task<CertificateDto> Handle(CreateCertificateCommand request, CancellationToken cancellationToken)
	{
		var certificate = mapper.Map<Certificate>(request);
		var uploaderResult = await fileUploader.UploadDefault(request.Image, AppDirectories.Images, "Certificates");

		certificate.Image = uploaderResult.ToLower();
		var certificateResult = await certificateRepository.CreateAsync(certificate);

		return mapper.Map<CertificateDto>(certificateResult);
		
 	}
}
