using ServiceHost.Responses;
using System.Text.Json.Serialization;

namespace ServiceHost.ApiResponses.Messages
{
	public class GetUnReadMessageCountResponse : IResponse<long>
	{
		public GetUnReadMessageCountResponse(bool ok, long result)
		{
			Ok = ok;
			Result = result;
		}

		public bool Ok { get; }

		public long Result { get; }

		[JsonIgnore]
		public string Message => string.Empty;
	}
}
