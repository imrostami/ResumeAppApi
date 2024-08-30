namespace ResumeAppApi.Application.Messages.Commands.ReadMessage;

public class ReadMessageByIdQuery : IRequest<bool>
{
	public ReadMessageByIdQuery(int messageId)
	{
		MessageId = messageId;
	}

	public int MessageId { get; set; }
}
