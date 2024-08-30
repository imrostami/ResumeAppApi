using ResumeAppApi.Application.Informations.Commands.CreateInformation;
using ResumeAppApi.Application.Informations.Commands.UpdateInformation;
using ResumeAppApi.Application.Informations.Dtos;

namespace ResumeAppApi.Application.Informations;

public class InformationMapper : Profile
{
    public InformationMapper()
    {
        CreateMap<Information, InformationDto>()
            .ForMember(x=>x.Id,obj=>obj.MapFrom(map=>
            map.InformationId));

        CreateMap<CreateInformationCommand, Information>();

        CreateMap<UpdateInformationCommand, Information>()
            .ForMember(x => x.InformationId, obj => obj.MapFrom(map =>
            map.Id));
        
    }
}
