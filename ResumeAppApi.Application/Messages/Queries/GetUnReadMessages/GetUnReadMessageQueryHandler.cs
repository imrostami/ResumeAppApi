namespace ResumeAppApi.Application.Messages.Queries.GetUnReadMessages;

public class GetUnReadMessagesQueryHandler(
	IMessageRepository messageRepository,
	IMapper mapper) : IRequestHandler<GetUnReadMessagesQuery, IEnumerable<UnReadMessageDto>>
{
	public async Task<IEnumerable<UnReadMessageDto>> Handle(GetUnReadMessagesQuery request, CancellationToken cancellationToken)
	{
		var unReadMessages = await messageRepository.GetUnReadMessages();
		return mapper.Map<IEnumerable<UnReadMessageDto>>(unReadMessages);
	}
}
