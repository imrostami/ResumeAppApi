
namespace ResumeAppApi.Application.WorkTips.Commands.UpdateWorkTip
{
	public class UpdateWorkTipCommandHandler(IWorkTipsRepository workTipsRepository,
		IMapper mapper) : IRequestHandler<UpdateWorkTipCommand, bool>
	{
		public async Task<bool> Handle(UpdateWorkTipCommand request, CancellationToken cancellationToken)
		{
			var workTip = await workTipsRepository.GetBy(request.Id);

			if (workTip is null)
				return false;

			var mappedWorkTip = mapper.Map(request, workTip);
			await workTipsRepository.UpdateAsync(mappedWorkTip);
			return true;

		}
	}
}
