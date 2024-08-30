namespace ResumeAppApi.Application.WorkSampleCategories.Commands.UpdateWorkSampleCategory;

public class UpdateWorkSampleCategoryCommand : IRequest<bool>
{
    public int Id { get; set; }
    public string CategoryName { get; set; }
}
