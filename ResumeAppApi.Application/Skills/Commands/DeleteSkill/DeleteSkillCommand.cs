namespace ResumeAppApi.Application.Skills.Commands.DeleteSkill;

public class DeleteSkillCommand : IRequest<bool>
{
    public int Id { get; set; }
}
