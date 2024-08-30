using ResumeAppApi.Application.WorkSamples.Dtos;
using ServiceHost.Responses;
using System.Text.Json.Serialization;

namespace ServiceHost.ApiResponses.WorkSamples
{
	public class GetWorkSampleResponse(WorkSampleDto workSampleDto) : IResponse<WorkSampleDto>
	{
		public bool Ok => workSampleDto != null;

		public WorkSampleDto Result => workSampleDto;

		[JsonIgnore]
		public string Message => string.Empty;
	}
}
