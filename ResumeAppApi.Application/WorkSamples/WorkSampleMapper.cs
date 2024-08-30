using ResumeAppApi.Application.WorkSampleCategories.Commands.UpdateWorkSampleCategory;
using ResumeAppApi.Application.WorkSampleCategories.Dtos;
using ResumeAppApi.Application.WorkSamples.Commands.CreateWorkSample;
using ResumeAppApi.Application.WorkSamples.Dtos;
using ResumeAppApi.Domain.Entities.WorkSampleAgg;

namespace ResumeAppApi.Application.WorkSamples;

public class WorkSampleMapper : Profile
{
    public WorkSampleMapper()
    {
        CreateMap<WorkSample, WorkSampleDto>()
            .ForMember(x => x.Category, obj => obj.MapFrom(map => new WorkSampleCategoryDto()
            {
                Name = map.Name,
                Id = map.CategoryId,
            }))
            .ForMember(x=>x.Id,obj=>obj.MapFrom(map=>
            map.SampleId)).ReverseMap();

        CreateMap<CreateWorkSampleCommand, WorkSample>().ReverseMap();
        CreateMap<UpdateWorkSampleCategoryCommand, WorkSample>().ReverseMap();
            
    }
}
