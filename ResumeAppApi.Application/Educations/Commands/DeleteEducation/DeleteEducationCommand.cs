namespace ResumeAppApi.Application.Educations.Commands.DeleteEducation;

public class DeleteEducationCommand : IRequest<bool>
{
    public int Id { get; set; }
}
