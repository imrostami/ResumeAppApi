using ResumeAppApi.Application.Informations.Dtos;
using ServiceHost.FileUploader;

namespace ResumeAppApi.Application.Informations.Commands.CreateInformation;

public class CreateInformationCommandHandler(IInformationRepository informationRepository,
	IMapper mapper) : IRequestHandler<CreateInformationCommand, InformationDto>
{
	public async Task<InformationDto?> Handle(CreateInformationCommand request, CancellationToken cancellationToken)
	{
		var information = await informationRepository.GetFirst();

		if (information is not null)
			return null;


		var mappedInformation = mapper.Map<Information>(request);
		var createInformationResult = await informationRepository.CreateAsync(mappedInformation);

		return mapper.Map<InformationDto>(createInformationResult);
	}
}
