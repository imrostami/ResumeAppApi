using Microsoft.AspNetCore.Http;

namespace ResumeAppApi.Application.WorkSamples.Commands.UpdateWorkSample;

public class UpdateWorkSampleCommand : IRequest<bool>
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
	public int CategoryId { get; set; } = default!;
	public string Description { get; set; } = default!;
	public string PictureAlt { get; set; } = default!;
}
