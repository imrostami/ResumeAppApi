using ResumeAppApi.Application.Educations.Dtos;

namespace ResumeAppApi.Application.Educations.Commands.CreateEducation;

public class CreateEducationCommand : IRequest<EducationDto>
{
	public string University { get; set; } = default!;
	public string Title { get; set; } = default!;
	public string Description { get; set; } = default!;
	public string StartDate { get; set; } = default!;
	public string EndDate { get; set; } = default!;
}
