using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.WorkSampleCategoreis
{
	public class UpdateWorkSampleCategoryResponse(bool ok) : IResponse
	{
		public bool Ok => ok;

		public string Message => ok? ResponseMessage.Updated():
			ResponseMessage.NotFound();
	}
}
