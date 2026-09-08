using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using ResumeAppApi.Application.Educations.Dtos;

namespace ResumeAppApi.Application.Educations.Queries.GetEducationsQuery;

public class GetEducationsQueryHandler(IEducationRepository educationRepository,
	IMapper mapper) : IRequestHandler<GetEducationsQuery, IEnumerable<EducationDto>>
{
	public async Task<IEnumerable<EducationDto>> Handle(GetEducationsQuery request, CancellationToken cancellationToken)
		=> await educationRepository.Query()
		.ProjectTo<EducationDto>(mapper.ConfigurationProvider)
		.ToListAsync();
}
