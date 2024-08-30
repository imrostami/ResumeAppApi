using MD.PersianDateTime.Standard;
using ResumeAppApi.Application.Educations.Commands.CreateEducation;
using ResumeAppApi.Application.Educations.Commands.UpdateEducation;
using ResumeAppApi.Application.Educations.Dtos;

namespace ResumeAppApi.Application.Educations;

public class EductionMapper : Profile
{
    public EductionMapper()
    {
		var dateFunction = new Func<string, DateTime>(date => PersianDateTime.Parse(date).ToDateTime());

        CreateMap<Education, EducationDto>()
             .ForMember(dto => dto.StartDate, eduction => eduction
             .MapFrom(eductionMap => new PersianDateTime(eductionMap.StartDate).ToShortDateString()))

			 .ForMember(dto => dto.StartDateLong, eduction => eduction
	 .MapFrom(eductionMap => new PersianDateTime(eductionMap.StartDate).ToLongDateString()))

			 .ForMember(dto => dto.EndDate, eduction => eduction
			 .MapFrom(eductionMap => new PersianDateTime(eductionMap.EndDate).ToShortDateString()))

			 .ForMember(dto => dto.EndDateLong, eduction => eduction
	 .MapFrom(eductionMap => new PersianDateTime(eductionMap.EndDate).ToLongDateString()));



		CreateMap<CreateEducationCommand, Education>()
			.ForMember(x => x.StartDate,
			obj => obj.MapFrom(map => dateFunction(map.StartDate)))
			
			.ForMember(x=>x.EndDate,
			obj=>obj.MapFrom(map=>dateFunction(map.EndDate)));


		CreateMap<UpdateEducationCommand, Education>()

			.ForMember(x => x.StartDate,
			obj => obj.MapFrom(map => dateFunction(map.StartDate)))

			.ForMember(x => x.EndDate,
			obj => obj.MapFrom(map => dateFunction(map.EndDate)));





	}
}
