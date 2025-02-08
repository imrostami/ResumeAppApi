using ResumeAppApi.Application.ContentStorages.Dtos;

namespace ResumeAppApi.Application.ContentStorages.Queries.GetStorageById;

public class GetStorageByIdQuery : IRequest<ContentStorageDto>
{
	public int Id { get; set; }
}
