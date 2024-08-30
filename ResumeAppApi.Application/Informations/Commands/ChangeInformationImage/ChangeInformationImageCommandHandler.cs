
using ServiceHost.FileUploader;

namespace ResumeAppApi.Application.Informations.Commands.ChangeInformationImage;

public class ChangeInformationImageCommandHandler(IInformationRepository informationRepository,
	IMapper mapper , IFileUploader fileUploader) : IRequestHandler<ChangeInformationImageCommand, bool>
{
	public async Task<bool> Handle(ChangeInformationImageCommand request, CancellationToken cancellationToken)
	{
		var information = await informationRepository.GetFirst();

		if (information is null)
			return false;

		var uploadInformationImageResult = await fileUploader.UploadDefault(request.Image, AppDirectories.Images, "UserImages");
		information.Picture = uploadInformationImageResult;
		information.PictureAlt = request.PictureAlt;

		await informationRepository.UpdateAsync(information);
		return true;
		
	}
}
