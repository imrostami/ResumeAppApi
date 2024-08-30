using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.WorkTips
{
	public class DeleteWorkTipResponse(bool ok) : IResponse
	{
		public bool Ok => ok;

		public string Message => ok ? ResponseMessage.Deleted() :
			ResponseMessage.NotFound();
	}
}
