using ResumeAppApi.Domain.Contracts;
using ResumeAppApi.Domain.Entities.MessageAgg;

namespace ResumeAppApi.Domain.Repositories
{
	public interface IMessageRepository:IRepositoryBase<Message>
	{
		public Task<IEnumerable<Message>> GetUnReadMessages();
		public Task<long> GetUnReadMessagesCount();
	}
}
