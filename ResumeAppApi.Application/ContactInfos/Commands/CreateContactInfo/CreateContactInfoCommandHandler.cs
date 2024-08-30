namespace ResumeAppApi.Application.ContactInfos.Commands.CreateContactInfo;

/// <summary>
///  در صورتی که true باشد ایجاد شده در صورتی که false باشد از قبل موجود است
/// </summary>

public class CreateContactInfoCommandHandler(IContactInfoRepository contactInfoRepository
	,IMapper mapper) : IRequestHandler<CreateContactInfoCommand, bool>
{
	public async Task<bool> Handle(CreateContactInfoCommand request, CancellationToken cancellationToken)
	{
		var contactInfo = await contactInfoRepository.GetBy(request.ContactName);

		if (contactInfo != null)
			return false;

		var contact = mapper.Map<ContactInfo>(request);
		await contactInfoRepository.CreateAsync(contact);
		return true;
	}
}
