using ResumeAppApi.Application.ContentStorages.Dtos;
using ServiceHost.Responses;
using System.Text.Json.Serialization;

namespace ServiceHost.ApiResponses.ContentStorages
{
	public class GetStorageResponse(ContentStorageDto storage) : IResponse<ContentStorageDto>
	{
		public bool Ok => storage is not null;

		public ContentStorageDto Result => storage;

		[JsonIgnore]
		public string Message => "";
	}
}
