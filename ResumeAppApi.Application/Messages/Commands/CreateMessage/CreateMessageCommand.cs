namespace ResumeAppApi.Application.Messages.Commands.CreateMessage;

public class CreateMessageCommand : IRequest<MessageDto>
{
	public string Email { get; set; }
	public string Title { get; set; }
	public string SenderFirstName { get; set; }
	public string SenderLastName { get; set; }
	public string Body { get; set; }


}
