namespace ResumeAppApi.Application.WorkSampleCategories.Commands.DeleteWorkSampleCategory;

public class DeleteWorkSampleCategoryCommand : IRequest<bool>
{
    public int Id { get; set; }
}
