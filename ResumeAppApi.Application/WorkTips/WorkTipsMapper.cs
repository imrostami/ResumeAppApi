using ResumeAppApi.Application.WorkTips.Commands.CreateWorkTip;
using ResumeAppApi.Application.WorkTips.Commands.UpdateWorkTip;
using ResumeAppApi.Application.WorkTips.Dtos;
using ResumeAppApi.Domain.Entities;


namespace ResumeAppApi.Application.WorkTips;

public class WorkTipsMapper : Profile
{
    public WorkTipsMapper()
    {
        CreateMap<WorkTip, WorkTipDto>()
            .ForMember(x=>x.Id,obj=>obj.MapFrom(map=>
            map.TipId));

        CreateMap<CreateWorkTipCommand, WorkTip>();
        
        
        CreateMap<UpdateWorkTipCommand, WorkTip>()
            .ForMember(x => x.TipId, obj =>
            obj.MapFrom(map => map.Id));
    }
}
