
namespace ResumeAppApi.Application.Certificates.Commands.DeleteCertificate;

public class DeleteCertificateCommandHandler(ICertificateRepository certificateRepository) : IRequestHandler<DeleteCertificateCommand, bool>
{
	public async Task<bool> Handle(DeleteCertificateCommand request, CancellationToken cancellationToken)
	{
		var certificate = await certificateRepository.GetBy(request.Id);

		if (certificate is null)
			return false;

		await certificateRepository.DeleteAsync(certificate);
		return true;
	}
}
