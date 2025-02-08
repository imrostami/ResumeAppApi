
using ResumeAppApi.Application.ContentStorages.Dtos;

namespace ResumeAppApi.Application.ContentStorages.Commands.UpdateStorage;

public class UpdateStorageCommandHandler(IMapper mapper,IContentStorageRepository contentStorage) : IRequestHandler<UpdateStorageCommand, ContentStorageDto>
{
	public async Task<ContentStorageDto?> Handle(UpdateStorageCommand request, CancellationToken cancellationToken)
	{
		var storage = await contentStorage.GetBy(request.StorageId);

		if (storage is null)
			return null;

		var mappedStorage = mapper.Map(request, storage);
		var updateResult = await contentStorage.UpdateAsync(mappedStorage);
		return mapper.Map<ContentStorageDto>(updateResult);
	}
}
