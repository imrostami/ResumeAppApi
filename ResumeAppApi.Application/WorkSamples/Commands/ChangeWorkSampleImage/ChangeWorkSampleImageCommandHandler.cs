
namespace ResumeAppApi.Application.WorkSamples.Commands.ChangeWorkSampleImage;

public class ChangeWorkSampleImageCommandHandler(IWorkSampleRepository workSampleRepository,
	IFileUploader fileUploader) : IRequestHandler<ChangeWorkSampleImageCommand, bool>
{
	public async Task<bool> Handle(ChangeWorkSampleImageCommand request, CancellationToken cancellationToken)
	{
		var workSample = await workSampleRepository.GetBy(request.Id);

		if (workSample is null)
			return false;

		var fileUploadResult = await fileUploader.UploadDefault(request.Image, AppDirectories.Images, "WorkSamples");
		workSample.Picture = fileUploadResult;
		await workSampleRepository.UpdateAsync(workSample);
		return true;


	}
}
