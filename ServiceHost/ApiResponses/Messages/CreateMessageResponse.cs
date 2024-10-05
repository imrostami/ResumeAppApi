using ResumeAppApi.Application.Messages;
using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.Messages
{
	public class CreateMessageResponse(bool ok,string message,MessageDto messageDto) : IResponse
	{

		public bool Ok { get; } = ok;

		public object Result { get; } = messageDto;

		public string Message => message;
	}
}
