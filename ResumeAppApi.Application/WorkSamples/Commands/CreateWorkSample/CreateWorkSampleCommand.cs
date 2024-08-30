using Microsoft.AspNetCore.Http;
using ResumeAppApi.Application.WorkSamples.Dtos;

namespace ResumeAppApi.Application.WorkSamples.Commands.CreateWorkSample;

public class CreateWorkSampleCommand : IRequest<WorkSampleDto>
{
	public string Name { get; set; } = default!;
    public int CategoryId { get; set; } = default!;
	public string Description { get; set; } = default!;
	public IFormFile Picture { get; set; } = default!;
	public string PictureAlt { get; set; } = default!;
}
