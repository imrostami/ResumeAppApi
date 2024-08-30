namespace ResumeAppApi.Application.ContactInfos.Commands.CreateContactInfo;

public class CreateContactInfoCommand : IRequest<bool>
{
	public string ContactName { get; set; }
	public string ContactValue { get; set; }
}
