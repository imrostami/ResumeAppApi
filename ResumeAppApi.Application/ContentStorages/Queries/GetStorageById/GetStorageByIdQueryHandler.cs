using AutoMapper;
using ResumeAppApi.Application.ContentStorages.Dtos;
using ResumeAppApi.Domain.Entities.ContentStorageAgg;

namespace ResumeAppApi.Application.ContentStorages.Queries.GetStorageById;

public class GetStorageByIdQueryHandler(IMapper mapper,IContentStorageRepository contentStorage) : IRequestHandler<GetStorageByIdQuery, ContentStorageDto>
{
	public async Task<ContentStorageDto> Handle(GetStorageByIdQuery request, CancellationToken cancellationToken)
	{
		var storage = await contentStorage.GetBy(request.Id);

		if (storage is null)
			return null;

		return mapper.Map<ContentStorageDto>(storage);
	}
}
