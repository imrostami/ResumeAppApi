namespace ResumeAppApi.Domain.Entities.MessageAgg;

public class MessageReply
{
	public int Id { get; set; }
    public bool IsOwner { get; set; }

    public int MessageId { get; set; }

	public Message Message { get; set; }

	public string ReplyBody { get; set; }

    public DateTime ReplyDate { get; set; }
}
