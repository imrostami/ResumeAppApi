using Microsoft.AspNetCore.Http;

namespace ResumeAppApi.Application.WorkSamples.Commands.UpdateWorkSample;

public class UpdateWorkSampleCommand : IRequest<bool>
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
	public int CategoryId { get; set; } = default!;
	public string Description { get; set; } = default!;
	public bool IsPinned { get; set; }
	public string ShortDescription { get; set; }
	public string? Url { get; set; }
}
