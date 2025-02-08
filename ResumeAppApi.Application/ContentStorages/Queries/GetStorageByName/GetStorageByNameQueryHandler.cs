using ResumeAppApi.Application.ContentStorages.Dtos;

namespace ResumeAppApi.Application.ContentStorages.Queries.GetStorageByName;

public class GetStorageByNameQueryHandler(IMapper mapper,IContentStorageRepository contentStorage) : IRequestHandler<GetStorageByNameQuery, ContentStorageDto>
{
	public async Task<ContentStorageDto> Handle(GetStorageByNameQuery request, CancellationToken cancellationToken)
	{
		var storage = await contentStorage.GetByName(request.Name);

		if (storage is null)
			return null;

		return mapper.Map<ContentStorageDto>(storage);
	}
}
