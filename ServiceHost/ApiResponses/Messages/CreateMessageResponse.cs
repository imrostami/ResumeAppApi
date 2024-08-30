using ResumeAppApi.Application.Messages;
using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.Messages
{
	public class CreateMessageResponse(bool ok,string message,int messageId) : IResponse
	{

		public bool Ok { get; } = ok;

		public object Result { get; } = messageId;

		public string Message => message;
	}
}
