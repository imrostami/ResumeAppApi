using ResumeAppApi.Application.WorkSamples.Dtos;

namespace ResumeAppApi.Application.WorkSamples.Queries.GetWorkSampleById;

public class GetWorkSampleByIdQueryHandler(IWorkSampleRepository workSampleRepository,
	IMapper mapper) : IRequestHandler<GetWorkSampleByIdQuery, WorkSampleDto>
{
	public async Task<WorkSampleDto?> Handle(GetWorkSampleByIdQuery request, CancellationToken cancellationToken)
	{
		var workSample = await workSampleRepository.GetBy(request.Id);

		if (workSample is null)
			return null;

		return mapper.Map<WorkSampleDto>(workSample);
	}
}
