using AutoMapper;
using MediatR;
using ResumeAppApi.Application.Skills.Dtos;
using ResumeAppApi.Domain.Repositories;

namespace ResumeAppApi.Application.Skills.Queries.GetSkills;

public class GetSkillsQueryHandler(ISkillRepository skillRepository,
    IMapper mapper) : IRequestHandler<GetSkillsQuery, IEnumerable<SkillDto>>
{
    public async Task<IEnumerable<SkillDto>> Handle(GetSkillsQuery request, CancellationToken cancellationToken)
    {
        var skills = await skillRepository.GetAll();
        return mapper.Map<IEnumerable<SkillDto>>(skills);
    }
}
