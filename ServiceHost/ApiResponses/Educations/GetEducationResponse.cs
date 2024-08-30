using ResumeAppApi.Application.Educations.Dtos;
using ResumeAppApi.Domain.Entities.PortfolioAgg;
using ServiceHost.Responses;
using System.Text.Json.Serialization;

namespace ServiceHost.ApiResponses.Educations
{
	public class GetEducationResponse(EducationDto education) : IResponse<EducationDto>
	{
		public bool Ok => education != null;

		public EducationDto Result => education;

		[JsonIgnore]
		public string Message => string.Empty;
	}
}
