using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ResumeAppApi.Application.Skills.Dtos;
using ResumeAppApi.Domain.Repositories;

namespace ResumeAppApi.Application.Skills.Queries.GetSkills;

public class GetSkillsQueryHandler(ISkillRepository skillRepository,
    IMapper mapper) : IRequestHandler<GetSkillsQuery, IEnumerable<SkillDto>>
{
    public async Task<IEnumerable<SkillDto>> Handle(GetSkillsQuery request, CancellationToken cancellationToken)
        => await skillRepository.Query()
        .ProjectTo<SkillDto>(mapper.ConfigurationProvider)
        .ToListAsync();
}
