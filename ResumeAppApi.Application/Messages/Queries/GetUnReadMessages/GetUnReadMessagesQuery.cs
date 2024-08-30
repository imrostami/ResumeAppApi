using MediatR;
using ResumeAppApi.Application.Messages.Dtos;

namespace ResumeAppApi.Application.Messages.Queries.GetUnReadMessages;

public class GetUnReadMessagesQuery : IRequest<IEnumerable<UnReadMessageDto>>
{
}
