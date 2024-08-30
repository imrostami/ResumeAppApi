
namespace ResumeAppApi.Application.Skills.Commands.UpdateSkill;

public class UpdateSkillCommandHandler(ISkillRepository skillRepository,
	IMapper mapper) : IRequestHandler<UpdateSkillCommand, bool>
{
	public async Task<bool> Handle(UpdateSkillCommand request, CancellationToken cancellationToken)
	{
		var skill = await skillRepository.GetBy(request.Id);

		if (skill is null)
			return false;

		var mappedSkill = mapper.Map(request, skill);
		await skillRepository.UpdateAsync(mappedSkill);
		return true;



	}
}
