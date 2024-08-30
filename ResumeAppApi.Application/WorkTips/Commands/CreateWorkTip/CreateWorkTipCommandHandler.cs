
using ResumeAppApi.Application.WorkTips.Dtos;
using ServiceHost.FileUploader;

namespace ResumeAppApi.Application.WorkTips.Commands.CreateWorkTip;

public class CreateWorkTipCommandHandler(IWorkTipsRepository workTipsRepository,
	IMapper mapper,IFileUploader fileUploader) : IRequestHandler<CreateWorkTipCommand, WorkTipDto>
{
	public async Task<WorkTipDto> Handle(CreateWorkTipCommand request, CancellationToken cancellationToken)
	{
		var workTip = mapper.Map<WorkTip>(request);
		
		var uploadResult = await fileUploader.UploadDefault(request.Icon, AppDirectories.Images, "WorkTipIcons");
		
		workTip.Icon = uploadResult;
		
		var addWorkTipResult = await workTipsRepository.CreateAsync(workTip);

		return mapper.Map<WorkTipDto>(addWorkTipResult);
	}
}
