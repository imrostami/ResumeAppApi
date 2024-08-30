namespace ResumeAppApi.Application.Messages.Queries.GetMessageById;

public class GetMessageByIdQueryHandler(IMessageRepository messagesRepository,
	IMapper mapper) : IRequestHandler<GetMessageByIdQuery, MessageDto>
{
	public async Task<MessageDto?> Handle(GetMessageByIdQuery request, CancellationToken cancellationToken)
	{
		var message = await messagesRepository.GetBy(request.MessageId);

		if (message is null)
			return null;

		return mapper.Map<MessageDto>(message);
	}
}
