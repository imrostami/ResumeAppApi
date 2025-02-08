using ResumeAppApi.Application.ContentStorages.Dtos;

namespace ResumeAppApi.Application.ContentStorages.Commands.UpdateStorage;

public class UpdateStorageCommand : IRequest<ContentStorageDto>
{

	public int StorageId { get; set; }
	public string Content { get; set; }
}
