namespace ResumeAppApi.Application.Skills.Commands.UpdateSkill;

public class UpdateSkillCommand : IRequest<bool>
{
    public int Id { get; set; }
	public int SkillScore { get; set; }
}
