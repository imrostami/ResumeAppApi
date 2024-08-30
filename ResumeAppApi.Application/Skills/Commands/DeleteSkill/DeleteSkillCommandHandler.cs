
namespace ResumeAppApi.Application.Skills.Commands.DeleteSkill;

public class DeleteSkillCommandHandler(ISkillRepository skillRepository) : IRequestHandler<DeleteSkillCommand, bool>
{
	public async Task<bool> Handle(DeleteSkillCommand request, CancellationToken cancellationToken)
	{
		var skill = await skillRepository.GetBy(request.Id);
		if (skill is null)
			return false;

		await skillRepository.DeleteAsync(skill);
		return true;
	}
}
