using ResumeAppApi.Application.WorkSampleCategories.Dtos;
using ResumeAppApi.Domain.Entities.WorkSampleAgg;

namespace ResumeAppApi.Application.WorkSamples.Dtos;

public class WorkSampleDto
{
	public int Id { get; set; }

	public WorkSampleCategoryDto Category { get; set; }

	public string Name { get; set; } = default!;
	public string Description { get; set; } = default!;
	public string Picture { get; set; } = default!;
	public string PictureAlt { get; set; } = default!;
}
