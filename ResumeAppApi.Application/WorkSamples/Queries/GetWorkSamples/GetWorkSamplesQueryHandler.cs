using ResumeAppApi.Application.WorkSamples.Dtos;

namespace ResumeAppApi.Application.WorkSamples.Queries.GetWorkSamples;

public class GetWorkSamplesQueryHandler(IWorkSampleRepository workSampleRepository,
	IMapper mapper) : IRequestHandler<GetWorkSamplesQuery, IEnumerable<WorkSampleDto>>
{
	public async Task<IEnumerable<WorkSampleDto>> Handle(GetWorkSamplesQuery request, CancellationToken cancellationToken)
	{
		var workSamples = await workSampleRepository.GetAll();
		return mapper.Map<IEnumerable<WorkSampleDto>>(workSamples);
	}

}
