using ResumeAppApi.Application.WorkSampleCategories.Dtos;

namespace ResumeAppApi.Application.WorkSampleCategories.Queries.GetWorkSampleCategoryById;

public class GetWorkSampleCategoryByIdQuery : IRequest<WorkSampleCategoryDto>
{
    public int Id { get; set; }
}
