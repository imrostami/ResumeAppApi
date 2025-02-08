using ResumeAppApi.Application.ContentStorages.Dtos;

namespace ResumeAppApi.Application.ContentStorages.Commands.CreateStorage;

public class CreateStorageCommand : IRequest<ContentStorageDto>
{
	public string Name { get; set; }
	public string Content { get; set; }
}
