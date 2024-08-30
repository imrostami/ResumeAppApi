using ResumeAppApi.Application.Informations.Dtos;

namespace ResumeAppApi.Application.Informations.Queries.GetInformation;

public class GetInformationQueryHandler(IInformationRepository informationRepository,
	IMapper mapper) : IRequestHandler<GetInformationQuery, InformationDto>
{
	public async Task<InformationDto?> Handle(GetInformationQuery request, CancellationToken cancellationToken)
	{
		var information = await informationRepository.GetFirst();

		if (information is null)
			return null;

		return mapper.Map<InformationDto>(information);

	}
}
