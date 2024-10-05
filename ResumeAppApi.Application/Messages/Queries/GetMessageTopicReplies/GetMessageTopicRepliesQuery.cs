namespace ResumeAppApi.Application.Messages.Queries.GetMessageTopicReplies;

public class GetMessageTopicRepliesQuery : IRequest<List<MessageReplyDto>>
{
    public string TopicId { get; set; }
}
