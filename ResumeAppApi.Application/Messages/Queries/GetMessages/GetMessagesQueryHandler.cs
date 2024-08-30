namespace ResumeAppApi.Application.Messages.Queries.GetMessages;

public class GetMessagesQueryHandler (IMessageRepository messageRepository,
	IMapper mapper) :
	IRequestHandler<GetMessagesQuery, IEnumerable<MessageDto>>
{
	public async Task<IEnumerable<MessageDto>> Handle(GetMessagesQuery request, CancellationToken cancellationToken)
	{
		var messages = await messageRepository.GetAll();
		return mapper.Map<IEnumerable<MessageDto>>(messages);
	}
}
