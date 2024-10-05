
namespace ResumeAppApi.Infrustructre.Mappers;

public class MessageReplyMapper : IEntityTypeConfiguration<MessageReply>
{
	public void Configure(EntityTypeBuilder<MessageReply> builder)
	{
		builder.ToTable("MessageReplies");

		builder.HasKey(x => x.Id);

		builder.Property(x=>x.ReplyBody).IsRequired();
	}
}
