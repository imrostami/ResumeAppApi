namespace ResumeAppApi.Application.ContactInfos.Queries.GetContactById;

public class GetContactByIdQuery : IRequest<ContactInfoDto>
{
    public int Id { get; set; }
}
