
namespace ResumeAppApi.Application.Messages.Commands.CreateMessageReply;

public class CreateMessageReplyCommandHandler(IMapper mapper,
	IMessageRepository messageRepository) : IRequestHandler<CreateMessageReplyCommand, bool>
{
	public async Task<bool> Handle(CreateMessageReplyCommand request, CancellationToken cancellationToken)
	{
		var message = await messageRepository.GetBy(request.MessageId);

		if (message is null)
			return false;


		var mappedReply = mapper.Map<MessageReply>(request);

		message.MessageReplies.Add(mappedReply);

		await messageRepository.UpdateAsync(message);

		return true;
	}
}
