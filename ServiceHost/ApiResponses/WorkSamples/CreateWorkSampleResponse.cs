using ResumeAppApi.Application.WorkSamples.Dtos;
using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.WorkSamples
{
	public class CreateWorkSampleResponse(WorkSampleDto workSample) : IResponse<WorkSampleDto>
	{
		public bool Ok => Result != null;

		public WorkSampleDto Result => workSample;

		public string Message => Ok ? ResponseMessage.Added() :
			ResponseMessage.Broken();
	}
}
