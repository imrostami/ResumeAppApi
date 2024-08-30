using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.WorkTips
{
	public class UpdateWorkTipResponse(bool ok) : IResponse
	{
		public bool Ok => ok;

		public string Message => ok ? ResponseMessage.Updated() :
			ResponseMessage.NotFound();
	}
}
