namespace ResumeAppApi.Application.ContactInfos.Queries.GetAllContacts;

public class GetAllContactQueryHandler(IContactInfoRepository contactInfoRepository,
	IMapper mapper) : IRequestHandler<GetAllContactQuery, IEnumerable<ContactInfoDto>>
{
	public async Task<IEnumerable<ContactInfoDto>> Handle(GetAllContactQuery request, CancellationToken cancellationToken)
	{
		var contacts = await contactInfoRepository.GetAll();
		return mapper.Map<IEnumerable<ContactInfoDto>>(contacts);

	}
}
