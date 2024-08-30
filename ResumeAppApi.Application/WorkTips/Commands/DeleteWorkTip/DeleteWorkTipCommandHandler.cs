
namespace ResumeAppApi.Application.WorkTips.Commands.DeleteWorkTip;

public class DeleteWorkTipCommandHandler(IWorkTipsRepository workTipsRepository,
	IMapper mapper) : IRequestHandler<DeleteWorkTipCommand, bool>
{
	public async Task<bool> Handle(DeleteWorkTipCommand request, CancellationToken cancellationToken)
	{
		var workTip = await workTipsRepository.GetBy(request.Id);

		if (workTip is null)
			return false;

		await workTipsRepository.DeleteAsync(workTip);
		return true;
	}
}
