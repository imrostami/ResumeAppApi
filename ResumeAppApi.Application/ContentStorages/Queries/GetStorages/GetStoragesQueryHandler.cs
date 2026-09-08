using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using ResumeAppApi.Application.ContentStorages.Dtos;

namespace ResumeAppApi.Application.ContentStorages.Queries.GetStorages;

public class GetStoragesQueryHandler(IMapper mapper,IContentStorageRepository contentStorage) : IRequestHandler<GetStoragesQuery, IEnumerable<ContentStorageDto>>
{
	public async Task<IEnumerable<ContentStorageDto>> Handle(GetStoragesQuery request, CancellationToken cancellationToken)
	{
		var storages = await contentStorage.GetAll();

		if (storages.Any())
			return await contentStorage.Query()
				.ProjectTo<ContentStorageDto>(mapper.ConfigurationProvider)
				.ToListAsync();

		return Enumerable.Empty<ContentStorageDto>();
	}
}
