using ResumeAppApi.Application.Messages;
using ServiceHost.Responses;
using System.Text.Json.Serialization;

namespace ServiceHost.ApiResponses.Messages
{
	public class GetMessageResponse(MessageDto message) : IResponse<MessageDto>
	{
		public bool Ok => Result != null;

		public MessageDto Result => message;

		[JsonIgnore]
		public string Message => string.Empty;
	}
}
