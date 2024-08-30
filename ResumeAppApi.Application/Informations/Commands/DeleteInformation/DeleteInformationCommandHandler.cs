
namespace ResumeAppApi.Application.Informations.Commands.DeleteInformation;

public class DeleteInformationCommandHandler(IInformationRepository informationRepository) : IRequestHandler<DeleteInformationCommand, bool>
{
	public async Task<bool> Handle(DeleteInformationCommand request, CancellationToken cancellationToken)
	{
		var information = await informationRepository.GetFirst();
		if (information is null)
			return false;

		await informationRepository.DeleteAsync(information);
		return true;
	}
}
