using Microsoft.AspNetCore.Http;

namespace ResumeAppApi.Application.WorkSamples.Commands.ChangeWorkSampleIcon;

public class ChangeWorkSampleIconCommand : IRequest<bool>
{
	public int Id { get; set; }
	public IFormFile Icon { get; set; }
}
