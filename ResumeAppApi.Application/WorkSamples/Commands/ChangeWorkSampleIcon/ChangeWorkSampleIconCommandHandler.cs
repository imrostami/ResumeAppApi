
using ResumeAppApi.Domain.Repositories;
using ServiceHost.FileUploader;

namespace ResumeAppApi.Application.WorkSamples.Commands.ChangeWorkSampleIcon
{
	public class ChangeWorkSampleIconCommandHandler(IWorkSampleRepository workSampleRepository,IMapper mapper,IFileUploader fileUploader) : IRequestHandler<ChangeWorkSampleIconCommand, bool>
	{
		public async Task<bool> Handle(ChangeWorkSampleIconCommand request, CancellationToken cancellationToken)
		{
			var workSample = await workSampleRepository.GetBy(request.Id);
			if (workSample is null)
				return false;

			var fileUploadResult = await fileUploader.UploadDefault(request.Icon, AppDirectories.Images, "WorkSampleIcons");
			workSample.Icon = fileUploadResult;
			await workSampleRepository.UpdateAsync(workSample);
			return true;
		}
	}
}
