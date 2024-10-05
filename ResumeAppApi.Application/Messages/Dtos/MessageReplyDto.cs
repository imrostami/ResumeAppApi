namespace ResumeAppApi.Application.Messages.Dtos;

public class MessageReplyDto
{
	public int Id { get; set; }
	public bool IsOwner { get; set; }
	public string TopicId { get; set; }
    
    public string Text { get; set; }
}
