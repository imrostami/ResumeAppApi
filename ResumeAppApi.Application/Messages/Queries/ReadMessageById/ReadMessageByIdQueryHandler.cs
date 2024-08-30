using MediatR;
using ResumeAppApi.Application.Messages.Commands.ReadMessage;
using ResumeAppApi.Domain.Repositories;

namespace ResumeAppApi.Application.Messages.Commands.ReadMessageById;

public class ReadMessageByIdQueryHandler(IMessageRepository messageRepository) : IRequestHandler<ReadMessageByIdQuery, bool>
{
	public async Task<bool> Handle(ReadMessageByIdQuery request, CancellationToken cancellationToken)
	{
		var message = await messageRepository.GetBy(request.MessageId);

		if(message is null)
			return false;

		message.IsRecived = true;
		await messageRepository.UpdateAsync(message);
		return true;

		

	}
}
