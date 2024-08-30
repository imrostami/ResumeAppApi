using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.Messages
{
	public class DeleteMessageResponse(bool ok) : IResponse
	{
		public bool Ok => ok;

		public string Message 
			=> Ok ? ResponseMessage.Deleted("پیام") :
			ResponseMessage.NotFound("پیام");
	}
}
