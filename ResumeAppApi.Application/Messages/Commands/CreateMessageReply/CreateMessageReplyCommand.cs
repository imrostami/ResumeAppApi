namespace ResumeAppApi.Application.Messages.Commands.CreateMessageReply;

public class CreateMessageReplyCommand : IRequest<bool>
{
    public string TopicId { get; set; }
	public int MessageId { get; set; }

	public string Text { get; set; }

    public bool IsOwner { get; set; }
}
