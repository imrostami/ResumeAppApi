using ResumeAppApi.Application.WorkSamples.Dtos;

namespace ResumeAppApi.Application.WorkSamples.Queries.GetWorkSampleByCategoryId;

public class GetWorkSampleByCategoryIdQueryHandler(IWorkSampleRepository workSampleRepository,
	IMapper mapper) : IRequestHandler<GetWorkSampleByCategoryIdQuery, IEnumerable<WorkSampleDto>>
{
	public async Task<IEnumerable<WorkSampleDto>> Handle(GetWorkSampleByCategoryIdQuery request, CancellationToken cancellationToken)
	{
		var workSample = await workSampleRepository.GetBy(request.CategoryId);

		if (workSample is null)
			return null;


		return mapper.Map<IEnumerable<WorkSampleDto>>(workSample);
	}
}
