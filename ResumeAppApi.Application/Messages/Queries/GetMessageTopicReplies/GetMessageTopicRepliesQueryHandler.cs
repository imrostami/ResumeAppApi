
namespace ResumeAppApi.Application.Messages.Queries.GetMessageTopicReplies;

public class GetMessageTopicRepliesQueryHandler(IMapper mapper,IMessageRepository messageRepository) : IRequestHandler<GetMessageTopicRepliesQuery, List<MessageReplyDto>>
{
	public async Task<List<MessageReplyDto>> Handle(GetMessageTopicRepliesQuery request, CancellationToken cancellationToken)
	{
		var messageReplies = await messageRepository.GetByTopicId(request.TopicId);
		var mappedReplies = mapper.Map<List<MessageReplyDto>>(messageReplies.MessageReplies);
	
		return mappedReplies;
	}
}
