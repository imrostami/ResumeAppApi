using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.WorkSamples
{
	public class EditWorkSampleResponse(bool ok) : IResponse
	{
		public bool Ok => ok;

		public string Message => ok ? ResponseMessage.Updated("نمونه کار") :
			ResponseMessage.NotFound();
	}
}
