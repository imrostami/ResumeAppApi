using Microsoft.AspNetCore.Http;

namespace ResumeAppApi.Application.WorkTips.Commands.ChangeWorkTipIcon;

public class ChangeWorkTipIconCommand : IRequest<bool>
{
    public int Id { get; set; }
    public IFormFile Icon { get; set; }
}
