namespace ResumeAppApi.Application.ContactInfos.Queries.GetContactById;

public class GetContactByIdQueryHandler(IContactInfoRepository contactInfoRepository,
	IMapper mapper) : IRequestHandler<GetContactByIdQuery, ContactInfoDto>
{
	public async Task<ContactInfoDto?> Handle(GetContactByIdQuery request, CancellationToken cancellationToken)
	{
		var contact = await contactInfoRepository.GetBy(request.Id);

		if (contact is null)
			return null;
		
		return mapper.Map<ContactInfoDto>(contact);
	}
}
