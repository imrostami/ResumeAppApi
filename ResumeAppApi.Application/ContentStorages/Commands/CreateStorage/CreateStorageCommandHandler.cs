using ResumeAppApi.Application.ContentStorages.Dtos;
using ResumeAppApi.Domain.Entities.ContentStorageAgg;

namespace ResumeAppApi.Application.ContentStorages.Commands.CreateStorage;

public class CreateStorageCommandHandler(IContentStorageRepository contentStorageRepository,IMapper mapper) : IRequestHandler<CreateStorageCommand, ContentStorageDto>
{
	public async Task<ContentStorageDto?> Handle(CreateStorageCommand request, CancellationToken cancellationToken)
	{
		var storage = mapper.Map<CreateStorageCommand,ContentStorage>(request);

		var createdStorage = await contentStorageRepository.CreateAsync(storage);

		if (createdStorage is null)
			return null;

		return mapper.Map<ContentStorageDto>(createdStorage);

	}
}
