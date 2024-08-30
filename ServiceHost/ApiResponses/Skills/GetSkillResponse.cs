using ResumeAppApi.Application.Skills.Dtos;
using ServiceHost.Responses;
using System.Text.Json.Serialization;

namespace ServiceHost.ApiResponses.Skills
{
	public class GetSkillResponse(SkillDto? skill) : IResponse<SkillDto>
	{
		public bool Ok => Result != null;

		public SkillDto? Result => skill;

		[JsonIgnore]
		public string Message => string.Empty;
	}
}
