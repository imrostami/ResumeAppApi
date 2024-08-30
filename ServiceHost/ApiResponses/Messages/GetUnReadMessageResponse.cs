using ResumeAppApi.Application.Messages.Dtos;
using ServiceHost.Responses;
using System.Text.Json.Serialization;

namespace ServiceHost.ApiResponses.Messages
{
	public class GetUnReadMessageResponse(IEnumerable<UnReadMessageDto> messages) : IResponse<IEnumerable<UnReadMessageDto>>
	{
		public bool Ok => Result != null;

		public IEnumerable<UnReadMessageDto> Result => messages;

		[JsonIgnore]
		public string Message => string.Empty;
	}
}
