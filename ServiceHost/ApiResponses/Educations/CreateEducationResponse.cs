using ResumeAppApi.Application.Educations.Dtos;
using ServiceHost.Responses;
using System.Text.Json.Serialization;

namespace ServiceHost.ApiResponses.Educations
{
	public class CreateEducationResponse(EducationDto education) : IResponse<EducationDto>
	{
		public bool Ok => education != null;

		public EducationDto Result => education;


		public string Message => Ok ? ResponseMessage.Added() :
			ResponseMessage.Broken();
	}
}
