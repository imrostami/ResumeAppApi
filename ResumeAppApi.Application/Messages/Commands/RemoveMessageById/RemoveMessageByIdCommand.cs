namespace ResumeAppApi.Application.Messages.Commands.RemoveMessageById;

public class RemoveMessageByIdCommand : IRequest<bool>
{
    public int MessageId { get; set; }
}
