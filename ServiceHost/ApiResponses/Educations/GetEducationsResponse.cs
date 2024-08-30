using ResumeAppApi.Application.Educations.Dtos;
using ServiceHost.Responses;
using System.Text.Json.Serialization;

namespace ServiceHost.ApiResponses.Educations
{
	public class GetEducationsResponse(IEnumerable<EducationDto> educationDtos) : IResponse<IEnumerable<EducationDto>>
	{
		public bool Ok => educationDtos != null;

		public IEnumerable<EducationDto> Result => educationDtos;

		[JsonIgnore]
		public string Message => string.Empty;
	}
}
