namespace ResumeAppApi.Application.Messages.Dtos;

public class MessageReplyDto
{
	public int Id { get; set; }
	public bool IsOwner { get; set; }
	public string TopicId { get; set; }
    
    public string Text { get; set; }

	public string CreationTime { get; set; }
	public string ShortDateTime { get; set; }
	public string LongDate { get; set; }
}
