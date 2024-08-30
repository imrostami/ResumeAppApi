namespace ResumeAppApi.Application.Educations.Dtos;

public class EducationDto
{
	public string University { get; set; } = default!;
	public string Title { get; set; } = default!;
	public string Description { get; set; } = default!;
	public string StartDate { get; set; } = default!;
	public string EndDate { get; set; } = default!;
	public string StartDateLong { get; set; } = default!;

	public string EndDateLong { get; set; } = default!;
}
