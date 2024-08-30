namespace ResumeAppApi.Application.Messages.Queries.GetMessageById;

public class GetMessageByIdQuery : IRequest<MessageDto>
{
    public int MessageId { get; set; }
}
