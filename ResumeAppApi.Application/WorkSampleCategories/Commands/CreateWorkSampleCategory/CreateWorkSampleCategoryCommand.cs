using ResumeAppApi.Application.WorkSampleCategories.Dtos;

namespace ResumeAppApi.Application.WorkSampleCategories.Commands.CreateWorkSampleCategory;

public class CreateWorkSampleCategoryCommand:IRequest<WorkSampleCategoryDto>
{
    public string CategoryName { get; set; }
}
