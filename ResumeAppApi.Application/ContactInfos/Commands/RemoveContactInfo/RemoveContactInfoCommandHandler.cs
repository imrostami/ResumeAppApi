namespace ResumeAppApi.Application.ContactInfos.Commands.RemoveContactInfo;

public class RemoveContactInfoCommandHandler(IContactInfoRepository contactInfoRepository) : IRequestHandler<RemoveContactInfoCommand, bool>
{
	public async Task<bool> Handle(RemoveContactInfoCommand request, CancellationToken cancellationToken) 
		=> await contactInfoRepository.DeleteAsync(request.Id);
}
