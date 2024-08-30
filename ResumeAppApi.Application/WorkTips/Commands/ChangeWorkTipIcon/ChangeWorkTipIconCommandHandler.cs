
using ServiceHost.FileUploader;

namespace ResumeAppApi.Application.WorkTips.Commands.ChangeWorkTipIcon
{
	public class ChangeWorkTipIconCommandHandler(IWorkTipsRepository workTipsRepository,
		IFileUploader fileUploader) : IRequestHandler<ChangeWorkTipIconCommand, bool>
	{
		public async Task<bool> Handle(ChangeWorkTipIconCommand request, CancellationToken cancellationToken)
		{
			var workTip = await workTipsRepository.GetBy(request.Id);
			
			if(workTip is null)
				return false;


			var uploadFileResult = await fileUploader.UploadDefault(request.Icon, AppDirectories.Images, "WorkTipIcons");
			workTip.Icon = uploadFileResult;
			await workTipsRepository.UpdateAsync(workTip);

			return true;
		
		}
	}
}
