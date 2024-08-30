using ResumeAppApi.Application.Educations.Dtos;

namespace ResumeAppApi.Application.Educations.Queries.GetEducationsQuery;

public class GetEducationsQueryHandler(IEducationRepository educationRepository,
	IMapper mapper) : IRequestHandler<GetEducationsQuery, IEnumerable<EducationDto>>
{
	public async Task<IEnumerable<EducationDto>> Handle(GetEducationsQuery request, CancellationToken cancellationToken)
	{
		var eductions = await educationRepository.GetAll();

		return mapper.Map<IEnumerable<EducationDto>>(eductions);
	}
}
