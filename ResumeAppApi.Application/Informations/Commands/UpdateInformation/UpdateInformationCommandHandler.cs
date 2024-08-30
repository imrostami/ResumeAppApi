
namespace ResumeAppApi.Application.Informations.Commands.UpdateInformation;

public class UpdateInformationCommandHandler(IInformationRepository informationRepository,
	IMapper mapper) : IRequestHandler<UpdateInformationCommand, bool>
{
	public async Task<bool> Handle(UpdateInformationCommand request, CancellationToken cancellationToken)
	{
		var information = await informationRepository.GetBy(request.Id);

		if (information is null)
			return false;

		var mappedInformation = mapper.Map(request, information);
		await informationRepository.UpdateAsync(mappedInformation);
		return true;
	}
}
