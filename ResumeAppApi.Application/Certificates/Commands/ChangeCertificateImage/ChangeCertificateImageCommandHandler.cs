
using ServiceHost.FileUploader;

namespace ResumeAppApi.Application.Certificates.Commands.ChangeCertificateImage
{
	public class ChangeCertificateImageCommandHandler(ICertificateRepository certificateRepository,
		IFileUploader fileUploader) : IRequestHandler<ChangeCertificateImageCommand, bool>
	{
		public async Task<bool> Handle(ChangeCertificateImageCommand request, CancellationToken cancellationToken)
		{
			var certificate = await certificateRepository.GetBy(request.CertificateId);

			if (certificate is null)
				return false;


			var uploadFileResult = await fileUploader.UploadDefault(request.Image, AppDirectories.Images, "Certificates");
			certificate.Image = uploadFileResult;
			await certificateRepository.UpdateAsync(certificate);

			return true;
		}
	}
}
