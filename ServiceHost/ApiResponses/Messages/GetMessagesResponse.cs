using ResumeAppApi.Application.Messages;
using ServiceHost.Responses;
using System.Text.Json.Serialization;

namespace ServiceHost.ApiResponses.Messages
{
    public class GetMessagesResponse :
        IResponse<IEnumerable<MessageDto>>
    {

        public bool Ok { get; }

        public IEnumerable<MessageDto> Result { get; }

        [JsonIgnore]
        public string Message => string.Empty;

		public GetMessagesResponse(bool ok, IEnumerable<MessageDto> result)
        {
            Ok = ok;
            Result = result;
        }
    }
}
