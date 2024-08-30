namespace ResumeAppApi.Application.Skills.Queries.GetSkillById;

public class GetSkillByIdQueryHandler(ISkillRepository skillRepository,
	IMapper mapper) : IRequestHandler<GetSkillByIdQuery, SkillDto>
{
	public async Task<SkillDto?> Handle(GetSkillByIdQuery request, CancellationToken cancellationToken)
	{
		var skill = await skillRepository.GetBy(request.Id);
		if (skill is null)
			return null;

		return mapper.Map<SkillDto>(skill);

	}
}
