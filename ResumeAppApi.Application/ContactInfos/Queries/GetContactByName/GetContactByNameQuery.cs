namespace ResumeAppApi.Application.ContactInfos.Queries.GetContactByName;

public class GetContactByNameQuery : IRequest<ContactInfoDto>
{
    public string Name { get; set; }
}
