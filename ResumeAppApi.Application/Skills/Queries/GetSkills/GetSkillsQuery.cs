using MediatR;
using ResumeAppApi.Application.Skills.Dtos;

namespace ResumeAppApi.Application.Skills.Queries.GetSkills;

public class GetSkillsQuery : IRequest<IEnumerable<SkillDto>>
{
}
