namespace ResumeAppApi.Application.Messages.Commands.CreateMessage;

public class CreateMessageCommandHandler(
	IMapper mapper,
	IMessageRepository messageRepository) : IRequestHandler<CreateMessageCommand, MessageDto>
{
	public async Task<MessageDto> Handle(CreateMessageCommand request, CancellationToken cancellationToken)
	{
		var message = mapper.Map<Message>(request);
		
		message.CreationTime = DateTime.Now;

		if(message.TopicId is null)
			message.TopicId = Guid.NewGuid().ToString("N");

		var createdMessage = await messageRepository.CreateAsync(message);

		return mapper.Map<MessageDto>(createdMessage);
	}
}
