namespace ResumeAppApi.Application.Skills.Queries.GetSkillById;

public class GetSkillByIdQuery : IRequest<SkillDto>
{
    public int Id { get; set; }
}
