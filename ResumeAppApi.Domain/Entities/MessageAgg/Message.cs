namespace ResumeAppApi.Domain.Entities.MessageAgg
{
    public class Message
    {
        public int MessageId { get; set; }
        public string Email { get; set; } = default!;
        public string Title { get; set; } = default!;
        public string SenderFirstName { get; set; }
        public string SenderLastName { get; set; }

        public string Body { get; set; } = default!;
        public bool IsRecived { get; set; } = default!;
        public DateTime CreationTime { get; set; }
        public string? TopicId { get; set; }
        public List<MessageReply> MessageReplies { get; set; } = new();
    }
}
