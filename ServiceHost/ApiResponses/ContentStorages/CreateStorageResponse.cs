using ResumeAppApi.Application.ContentStorages.Dtos;
using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.ContentStorages
{
	public class CreateStorageResponse(ContentStorageDto storage) : IResponse<ContentStorageDto>
	{
		public bool Ok => storage is not null;

		public ContentStorageDto Result => storage;

		public string Message => Ok ? ResponseMessage.Sucssesfuly() :
			ResponseMessage.Duplicate();
	}
}
