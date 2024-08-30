using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.Messages
{
	public class ReadMessageResponse(bool ok) : IResponse
	{
		public bool Ok => ok;

		public string Message 
			=> Ok ? ResponseMessage.Sucssesfuly() : 
			ResponseMessage.NotFound("پیام");
	}
}
