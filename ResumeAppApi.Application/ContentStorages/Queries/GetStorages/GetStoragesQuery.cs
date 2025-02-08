using ResumeAppApi.Application.ContentStorages.Dtos;

namespace ResumeAppApi.Application.ContentStorages.Queries.GetStorages;

public class GetStoragesQuery : IRequest<IEnumerable<ContentStorageDto>>
{
}
