using ResumeAppApi.Application.Skills.Dtos;
using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.Skills
{
	public class CreateSkillResponse(SkillDto? skill) : IResponse
	{
		public bool Ok => skill != null;

		public string Message 
			=> Ok ? ResponseMessage.Added() :
			ResponseMessage.Duplicate();
	}
}
