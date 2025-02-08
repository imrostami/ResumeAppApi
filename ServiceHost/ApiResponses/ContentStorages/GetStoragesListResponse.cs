using ResumeAppApi.Application.ContentStorages.Dtos;
using ServiceHost.Responses;
using System.Text.Json.Serialization;

namespace ServiceHost.ApiResponses.ContentStorages
{
	public class GetStoragesListResponse(IEnumerable<ContentStorageDto> storages) : IResponse<IEnumerable<ContentStorageDto>>
	{
		public bool Ok => true;

		public IEnumerable<ContentStorageDto> Result => storages;

		[JsonIgnore]
		public string Message => "";
	}
}
