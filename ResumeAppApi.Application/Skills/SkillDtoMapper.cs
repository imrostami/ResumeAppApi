using ResumeAppApi.Application.Skills.Commands.UpdateSkill;

namespace ResumeAppApi.Application.Skills
{
	public class SkillDtoMapper : Profile
	{
        public SkillDtoMapper()
        {
            CreateMap<Skill, SkillDto>()
                .ForMember(x => x.Id,
                obj => obj.MapFrom(map =>
                map.SkillId))

                .ForMember(x => x.SkillName,
                map => map.MapFrom(x => x.Name))

                .ForMember(x => x.SkillScore,
                map => map.MapFrom(x => x.Value));




            CreateMap<CreateSkillCommand, Skill>()
                .ForMember(x => x.Name, obj =>
                obj.MapFrom(map => map.SkillName))

                .ForMember(x => x.Value, obj =>
                obj.MapFrom(map => map.SkillScore));





            CreateMap<UpdateSkillCommand, Skill>()
                .ForMember(x => x.SkillId, obj =>
                obj.MapFrom(map => map.Id))

				.ForMember(x => x.Value, obj =>
				obj.MapFrom(map => map.SkillScore));
		}
    }
}
