using Microsoft.AspNetCore.Http;

namespace ResumeAppApi.Application.WorkTips.Commands.UpdateWorkTip;

public class UpdateWorkTipCommand : IRequest<bool>
{
    public int Id { get; set; }
    public string Title { get; set; }
	public string Caption { get; set; }
}
