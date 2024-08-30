
namespace ResumeAppApi.Application.Certificates.Commands.UpdateCertificate;

public class UpdateCertificateCommandHandler(ICertificateRepository certificateRepository,
	IMapper mapper) : IRequestHandler<UpdateCertificateCommand, bool>
{
	public async Task<bool> Handle(UpdateCertificateCommand request, CancellationToken cancellationToken)
	{
		var certificate = await certificateRepository.GetBy(request.CertificateId);

		if (certificate is null)
			return false;

		var mappedCertificate = mapper.Map(request, certificate);
		await certificateRepository.UpdateAsync(mappedCertificate);

		return true;
	}
}
