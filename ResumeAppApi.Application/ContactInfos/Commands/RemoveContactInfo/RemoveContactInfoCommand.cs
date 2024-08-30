namespace ResumeAppApi.Application.ContactInfos.Commands.RemoveContactInfo;

public class RemoveContactInfoCommand : IRequest<bool>
{
    public int Id { get; set; }
}
