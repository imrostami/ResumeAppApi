namespace ResumeAppApi.Application.ContactInfos.Commands.UpdateContactInfo;

public class UpdateContactInfoCommandHandler(IContactInfoRepository contactInfoRepository,
	 IMapper mapper) : IRequestHandler<UpdateContactInfoCommand, bool>
{
	public async Task<bool> Handle(UpdateContactInfoCommand request, CancellationToken cancellationToken)
	{
		var contact = await contactInfoRepository.GetBy(request.ContactId);

		if (contact is null)
			return false;



		var mappedContact = mapper.Map(request, contact);

		await contactInfoRepository.UpdateAsync(mappedContact);

		return true;










	}
}
