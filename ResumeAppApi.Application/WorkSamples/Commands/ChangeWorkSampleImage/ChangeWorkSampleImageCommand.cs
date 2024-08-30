using Microsoft.AspNetCore.Http;

namespace ResumeAppApi.Application.WorkSamples.Commands.ChangeWorkSampleImage;

public class ChangeWorkSampleImageCommand : IRequest<bool>
{
    public int Id { get; set; }
    public IFormFile Image { get; set; }
	public string PictureAlt { get; set; }
}
