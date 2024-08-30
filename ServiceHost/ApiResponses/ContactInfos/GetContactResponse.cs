using ResumeAppApi.Application.ContactInfos.Dtos;
using ServiceHost.Responses;
using System.Text.Json.Serialization;

namespace ServiceHost.ApiResponses.ContactInfos
{
	public class GetContactResponse(ContactInfoDto contactInfo) : IResponse<ContactInfoDto>
	{
		public bool Ok => Result != null;

		public ContactInfoDto Result => contactInfo;

		[JsonIgnore]
		public string Message => string.Empty;
	}
}
