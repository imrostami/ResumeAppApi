using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.Skills
{
	public class DeleteSkillResponse(bool ok) : IResponse
	{
		public bool Ok => ok;

		public string Message => ok ? ResponseMessage.Deleted():
			ResponseMessage.NotFound();
	}
}
