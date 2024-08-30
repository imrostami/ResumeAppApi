using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.WorkSamples
{
	public class DeleteWorkSampleResponse(bool ok) : IResponse
	{
		public bool Ok => ok;

		public string Message => ok ? ResponseMessage.Deleted() :
			ResponseMessage.NotFound();
	}
}
