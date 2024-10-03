using ResumeAppApi.Application.Messages;
using ResumeAppApi.Application.Messages.Dtos;
using ServiceHost.Responses;
using System.Text.Json.Serialization;

namespace ServiceHost.ApiResponses.Messages
{
    public class GetMessagesResponse :
        IResponse<MessagePaggedDto>
    {

        public bool Ok { get; }

        public MessagePaggedDto Result { get; }

        [JsonIgnore]
        public string Message => string.Empty;

		public GetMessagesResponse(bool ok,MessagePaggedDto result)
        {
            Ok = ok;
            Result = result;
        }
    }
}
