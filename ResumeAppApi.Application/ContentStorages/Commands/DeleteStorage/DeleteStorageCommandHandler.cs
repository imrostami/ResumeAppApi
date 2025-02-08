
namespace ResumeAppApi.Application.ContentStorages.Commands.DeleteStorage;

public class DeleteStorageCommandHandler(IContentStorageRepository contentStorageRepository) : IRequestHandler<DeleteStorageCommand, bool>
{
	public async Task<bool> Handle(DeleteStorageCommand request, CancellationToken cancellationToken)
	{
		var storage = await contentStorageRepository.GetBy(request.Id);

		if (storage is null)
			return false;

		await contentStorageRepository.DeleteAsync(storage);
		return true;
	}
}
