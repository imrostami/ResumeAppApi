namespace ResumeAppApi.Application.Messages.Commands.RemoveMessageById
{
	public class RemoveMessageByIdCommandHandler(IMessageRepository messagesRepository) : IRequestHandler<RemoveMessageByIdCommand, bool>
	{
		public async Task<bool> Handle(RemoveMessageByIdCommand request, CancellationToken cancellationToken)
		{
			var message = await messagesRepository.GetBy(request.MessageId);
			
			if (message is null)
				return false;

			await messagesRepository.DeleteAsync(message);
			return true;
		}
	}
}
