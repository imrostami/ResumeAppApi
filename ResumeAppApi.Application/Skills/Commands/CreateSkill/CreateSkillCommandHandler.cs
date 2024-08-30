
namespace ResumeAppApi.Application.Skills.Commands.CreateSkill;

public class CreateSkillCommandHandler(ISkillRepository skillRepository,
	IMapper mapper) : IRequestHandler<CreateSkillCommand, SkillDto>
{
	public async Task<SkillDto> Handle(CreateSkillCommand request, CancellationToken cancellationToken)
	{
		var isSkillExist = await skillRepository.Exist(request.SkillName);

		if (isSkillExist)
			return null;

		var skill = mapper.Map<Skill>(request);
		var createdSkillResult = await skillRepository.CreateAsync(skill);

		return mapper.Map<SkillDto>(createdSkillResult);
	}
}
