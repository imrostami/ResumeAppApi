using ResumeAppApi.Application.ContentStorages.Dtos;

namespace ResumeAppApi.Application.ContentStorages.Queries.GetStorages;

public class GetStoragesQueryHandler(IMapper mapper,IContentStorageRepository contentStorage) : IRequestHandler<GetStoragesQuery, IEnumerable<ContentStorageDto>>
{
	public async Task<IEnumerable<ContentStorageDto>> Handle(GetStoragesQuery request, CancellationToken cancellationToken)
	{
		var storages = await contentStorage.GetAll();

		if (storages.Any())
			return mapper.Map<IEnumerable<ContentStorageDto>>(storages);

		return Enumerable.Empty<ContentStorageDto>();
	}
}
