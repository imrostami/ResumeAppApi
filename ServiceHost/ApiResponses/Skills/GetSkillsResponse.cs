using ResumeAppApi.Application.Skills.Dtos;
using ServiceHost.Responses;
using System.Text.Json.Serialization;

namespace ServiceHost.ApiResponses.Skills
{
	public class GetSkillsResponse(IEnumerable<SkillDto> skills) : IResponse<IEnumerable<SkillDto>>
	{
		public bool Ok => Result != null;

		public IEnumerable<SkillDto> Result => skills;

		[JsonIgnore]
		public string Message => string.Empty;
	}
}
