using ResumeAppApi.Application.WorkTips.Dtos;

namespace ResumeAppApi.Application.WorkTips.Queries.GetTips;

public class GetWorkTipsQueryHandler(IWorkTipsRepository workTipsRepository,
	IMapper mapper) : IRequestHandler<GetWorkTipsQuery, IEnumerable<WorkTipDto>>
{
	public async Task<IEnumerable<WorkTipDto>> Handle(GetWorkTipsQuery request, CancellationToken cancellationToken)
	{
		var workTips = await workTipsRepository.GetAll();
		return mapper.Map<IEnumerable<WorkTipDto>>(workTips);
	}
}
