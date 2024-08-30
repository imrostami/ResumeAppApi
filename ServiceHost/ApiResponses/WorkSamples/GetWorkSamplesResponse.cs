using ResumeAppApi.Application.WorkSamples.Dtos;
using ServiceHost.Responses;
using System.Text.Json.Serialization;

namespace ServiceHost.ApiResponses.WorkSamples
{
	public class GetWorkSamplesResponse(IEnumerable<WorkSampleDto> workSamples) : IResponse<IEnumerable<WorkSampleDto>>
	{
		public bool Ok => Result != null;

		public IEnumerable<WorkSampleDto> Result => workSamples;

		[JsonIgnore]
		public string Message => string.Empty;
	}
}
