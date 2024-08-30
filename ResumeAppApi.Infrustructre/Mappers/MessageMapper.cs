
namespace ResumeAppApi.Infrustructre.Mappers
{
	public class MessageMapper : IEntityTypeConfiguration<Message>
	{
		public void Configure(EntityTypeBuilder<Message> builder)
		{
			builder.HasKey(x => x.MessageId);
			builder.Property(x => x.Title)
				.IsRequired()
				.HasMaxLength(100);

			builder.Property(x => x.SenderFirstName)
				.IsRequired()
				.HasMaxLength(50);


			builder.Property(x => x.SenderLastName)
				.IsRequired()
				.HasMaxLength(120);


			builder.Property(x => x.Body) 
				.IsRequired()
				.HasMaxLength(1200);
		}
	}
}
