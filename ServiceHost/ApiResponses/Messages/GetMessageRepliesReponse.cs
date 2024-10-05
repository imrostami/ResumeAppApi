using ResumeAppApi.Application.Messages.Dtos;
using ServiceHost.Responses;
using System.Text.Json.Serialization;

namespace ServiceHost.ApiResponses.Messages
{
	public class GetMessageRepliesReponse(List<MessageReplyDto> messageReplies) : IResponse<List<MessageReplyDto>>
	{
		public bool Ok => Result != null;

		public List<MessageReplyDto> Result => messageReplies;


		[JsonIgnore]
		public string Message { get; set; }
	}
}
