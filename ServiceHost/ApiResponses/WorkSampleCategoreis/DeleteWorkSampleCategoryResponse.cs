using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.WorkSampleCategoreis
{
	public class DeleteWorkSampleCategoryResponse(bool ok) : IResponse
	{
		public bool Ok => ok;

		public string Message => ok ? ResponseMessage.Deleted() :
			ResponseMessage.NotFound();
	}
}
