namespace ResumeAppApi.Application.Messages.Queries.GetMessages;

public class GetMessagesQueryHandler (IMessageRepository messageRepository,
	IMapper mapper) :
	IRequestHandler<GetMessagesQuery, MessagePaggedDto>
{
	public async Task<MessagePaggedDto> Handle(GetMessagesQuery request, CancellationToken cancellationToken)
	{
		var messages = await messageRepository.GetPagged(request.PageNumber,request.PageSize);
		var messagesCount = await messageRepository.GetMessagesCount();

		var mappedMessages = mapper.Map<IEnumerable<MessageDto>>(messages);


		return new MessagePaggedDto()
		{
			Messages = mappedMessages,
			PageNumber = request.PageNumber,
			PageSize = request.PageSize,
			TotalPages = (messagesCount / request.PageSize),
			TotalRecords = messagesCount
		};
	}
}
