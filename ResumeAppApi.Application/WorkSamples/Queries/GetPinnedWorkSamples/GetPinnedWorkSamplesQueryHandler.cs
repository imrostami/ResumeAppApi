
namespace ResumeAppApi.Application.WorkSamples.Queries.GetPinnedWorkSamples;

public class GetPinnedWorkSamplesQueryHandler(IMapper mapper,IWorkSampleRepository workSampleRepository) : IRequestHandler<GetPinnedWorkSamplesQuery, IEnumerable<WorkSampleDto>>
{
	public async Task<IEnumerable<WorkSampleDto>> Handle(GetPinnedWorkSamplesQuery request, CancellationToken cancellationToken)
	{
		var pinnedSamples = await workSampleRepository.GetPinnedWorkSamples();
		if(pinnedSamples.Any())
			return mapper.Map<IEnumerable<WorkSampleDto>>(pinnedSamples);

		return Enumerable.Empty<WorkSampleDto>();
	}
}
