namespace ServiceHost.Controllers;

[Route("api/[controller]")]
[ApiController]
public class IdentityController : ControllerBase
{
	[HttpGet("validateAuth")]
	[Authorize]
	public IActionResult ValidateToken()
		=> Ok();
}
