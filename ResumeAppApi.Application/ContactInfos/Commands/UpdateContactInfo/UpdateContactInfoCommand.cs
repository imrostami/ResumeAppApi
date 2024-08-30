namespace ResumeAppApi.Application.ContactInfos.Commands.UpdateContactInfo;

public class UpdateContactInfoCommand : IRequest<bool>
{
	public int ContactId { get; set; }
	public string ContactValue { get; set; }
}
