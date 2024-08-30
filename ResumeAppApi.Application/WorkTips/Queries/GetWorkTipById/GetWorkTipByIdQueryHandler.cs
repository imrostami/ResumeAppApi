using ResumeAppApi.Application.WorkTips.Dtos;

namespace ResumeAppApi.Application.WorkTips.Queries.GetWorkTipById;

public class GetWorkTipByIdQueryHandler(IWorkTipsRepository workTipsRepository,
	IMapper mapper) : IRequestHandler<GetWorkTipByIdQuery, WorkTipDto>
{
	public async Task<WorkTipDto?> Handle(GetWorkTipByIdQuery request, CancellationToken cancellationToken)
	{
		var workTip = await workTipsRepository.GetBy(request.Id);

		if (workTip is null)
			return null;

		return mapper.Map<WorkTipDto>(workTip);
	}
}
