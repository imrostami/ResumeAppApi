using ResumeAppApi.Application.ContentStorages.Dtos;

namespace ResumeAppApi.Application.ContentStorages.Queries.GetStorageByName;

public class GetStorageByNameQuery : IRequest<ContentStorageDto>
{
	public string Name { get; set; }
}
