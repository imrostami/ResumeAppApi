using Microsoft.AspNetCore.Http;
using ResumeAppApi.Application.WorkTips.Dtos;

namespace ResumeAppApi.Application.WorkTips.Commands.CreateWorkTip;

public class CreateWorkTipCommand:IRequest<WorkTipDto>
{
	public string Title { get; set; }
	public string Caption { get; set; }
	public IFormFile Icon { get; set; }
}
