namespace ResumeAppApi.Application.Skills.Commands.CreateSkill;

public class CreateSkillCommand : IRequest<SkillDto>
{
	public string SkillName { get; set; }
	public int SkillScore { get; set; }
}
