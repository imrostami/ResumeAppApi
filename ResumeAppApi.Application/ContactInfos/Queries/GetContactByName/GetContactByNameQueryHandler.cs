namespace ResumeAppApi.Application.ContactInfos.Queries.GetContactByName;

public class GetContactByNameQueryHandler(IContactInfoRepository contactInfoRepository,
	IMapper mapper) : IRequestHandler<GetContactByNameQuery, ContactInfoDto>
{
	public async Task<ContactInfoDto?> Handle(GetContactByNameQuery request, CancellationToken cancellationToken)
	{
		var contactInfo = await contactInfoRepository.GetBy(request.Name);

		if (contactInfo is null)
			return null;

		return mapper.Map<ContactInfoDto>(contactInfo);
	}
}
