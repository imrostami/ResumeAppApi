namespace ResumeAppApi.Application.Messages.Queries.GetUnReadMessagesCount;

public class GetUnReadMessagesCountQueryHandler(
	IMessageRepository messageRepository) : IRequestHandler<GetUnReadMessagesCountQuery, long>
{
	public async Task<long> Handle(GetUnReadMessagesCountQuery request, CancellationToken cancellationToken)
		=> await messageRepository.GetUnReadMessagesCount();
}
