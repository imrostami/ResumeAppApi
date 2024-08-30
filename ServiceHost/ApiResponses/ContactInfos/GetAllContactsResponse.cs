using ResumeAppApi.Application.ContactInfos.Dtos;
using ServiceHost.Responses;
using System.Text.Json.Serialization;

namespace ServiceHost.ApiResponses.ContactInfos
{
	public class GetAllContactsResponse(IEnumerable<ContactInfoDto> result) : IResponse<IEnumerable<ContactInfoDto>>
	{
		public bool Ok => Result != null;

		public IEnumerable<ContactInfoDto> Result => result;

		[JsonIgnore]
		public string Message => string.Empty;
	}
}
