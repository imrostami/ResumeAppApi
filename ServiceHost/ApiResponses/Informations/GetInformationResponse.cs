using ResumeAppApi.Application.Informations.Dtos;
using ServiceHost.Responses;
using System.Text.Json.Serialization;

namespace ServiceHost.ApiResponses.Informations
{
	public class GetInformationResponse(InformationDto information) : IResponse<InformationDto>
	{
		public bool Ok => information != null;

		public InformationDto? Result => information;

		[JsonIgnore]
		public string Message => string.Empty;
	}
}
