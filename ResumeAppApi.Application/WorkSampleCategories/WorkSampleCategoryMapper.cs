using ResumeAppApi.Application.WorkSampleCategories.Commands.CreateWorkSampleCategory;
using ResumeAppApi.Application.WorkSampleCategories.Commands.UpdateWorkSampleCategory;
using ResumeAppApi.Application.WorkSampleCategories.Dtos;
using ResumeAppApi.Domain.Entities.WorkSampleAgg;

namespace ResumeAppApi.Application.WorkSampleCategories;

public class WorkSampleCategoryMapper : Profile
{
    public WorkSampleCategoryMapper()
    {
        CreateMap<WorkSampleCategory, WorkSampleCategoryDto>()
            .ForMember(x => x.Id, x => x.MapFrom(x => x.CategoryId))
            .ForMember(x => x.Name, x => x.MapFrom(map => map.CategoryName))
            .ReverseMap();

        CreateMap<CreateWorkSampleCategoryCommand, WorkSampleCategory>()
            .ReverseMap();

        CreateMap<UpdateWorkSampleCategoryCommand, WorkSampleCategory>()
            .ForMember(x => x.CategoryId, obj => obj.MapFrom(map => map.Id))
            .ReverseMap();

        

    }
}
