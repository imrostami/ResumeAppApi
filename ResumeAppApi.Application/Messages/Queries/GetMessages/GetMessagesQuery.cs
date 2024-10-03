namespace ResumeAppApi.Application.Messages.Queries.GetMessages;

public class GetMessagesQuery : IRequest<MessagePaggedDto>
{
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
}
