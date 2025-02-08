using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.ContentStorages
{
	public class DeleteStorageResponse(bool ok) : IResponse
	{
		public bool Ok => ok;

		public string Message => ok ? ResponseMessage.Deleted() :
			ResponseMessage.NotFound();
	}
}
