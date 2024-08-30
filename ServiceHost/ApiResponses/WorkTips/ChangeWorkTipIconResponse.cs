using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.WorkTips
{
	public class ChangeWorkTipIconResponse(bool ok) : IResponse
	{
		public bool Ok => ok;

		public string Message => ok ? ResponseMessage.Updated("آیکون سرویس") :
			ResponseMessage.NotFound();
	}
}
