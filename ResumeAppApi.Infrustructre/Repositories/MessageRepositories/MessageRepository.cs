
namespace ResumeAppApi.Infrustructre.Repositories.MessageRepositories;

public class MessageRepository(AppDbContext context) : IMessageRepository
{
    public async Task<Message> CreateAsync(Message entity)
    {
        context.Messages.Add(entity);
        await context.SaveChangesAsync();
        return entity;

    }

    public async Task<bool> DeleteAsync(Message entity)
    {
        context.Messages.Remove(entity);
        var saveResult = await context.SaveChangesAsync();
        return saveResult >= 1;


    }

    public async Task<bool> DeleteAsync(int id)
    {
        var message = await context.Messages.FindAsync(id);
        if (message is null)
            return false;

        context.Messages.Remove(message);
        await context.SaveChangesAsync();
        return true;
    }

    public async Task<IEnumerable<Message>> GetAll()
        => await context.Messages.ToListAsync();

    public async Task<Message?> GetBy(int id)
        => await context.Messages.FindAsync(id);

    public async Task<IEnumerable<Message>> GetUnReadMessages()
    {
        var unReadMessages = await context.Messages
            .Where(x => !x.IsRecived)
            .ToListAsync();

        return unReadMessages;
    }

    public async Task<long> GetUnReadMessagesCount()
        => await context.Messages
        .CountAsync(x => !x.IsRecived);

	public async Task<Message> UpdateAsync(Message entity)
    {
        context.Messages.Update(entity);
        await context.SaveChangesAsync();
        return entity;
    }
}
