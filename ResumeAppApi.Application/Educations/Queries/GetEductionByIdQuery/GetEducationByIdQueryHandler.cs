using ResumeAppApi.Application.Educations.Dtos;

namespace ResumeAppApi.Application.Educations.Queries.GetEductionByIdQuery
{
	public class GetEducationByIdQueryHandler(IEducationRepository educationRepository,
		IMapper mapper) : IRequestHandler<GetEducationByIdQuery, EducationDto>
	{
		public async Task<EducationDto?> Handle(GetEducationByIdQuery request, CancellationToken cancellationToken)
		{
			var eduction = await educationRepository.GetBy(request.Id);

			if (eduction is null)
				return null;

			return mapper.Map<EducationDto>(eduction);
		}
	}
}
