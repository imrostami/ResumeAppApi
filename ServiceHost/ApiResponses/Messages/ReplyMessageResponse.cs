using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.Messages
{
	public class ReplyMessageResponse(bool ok) : IResponse
	{
		public bool Ok => ok;

		public string Message => ok ? ResponseMessage.Added("پاسخ") :
			ResponseMessage.NotFound("پیام");
	}
}
