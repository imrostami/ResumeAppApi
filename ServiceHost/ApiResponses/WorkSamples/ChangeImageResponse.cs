using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.WorkSamples
{
	public class ChangeImageResponse(bool ok) : IResponse
	{
		public bool Ok => ok;

		public string Message => ok ? ResponseMessage.Updated() :
			ResponseMessage.NotFound();
	}
}
