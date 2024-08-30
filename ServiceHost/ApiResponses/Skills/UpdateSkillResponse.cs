using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.Skills;

public class UpdateSkillResponse(bool ok) : IResponse
{
	public bool Ok => ok;

	public string Message => ok ? ResponseMessage.Updated():
		ResponseMessage.NotFound();
}
