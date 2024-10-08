﻿
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

			builder.Property(x => x.TopicId)
				.IsRequired(false)
				.HasMaxLength(300);


			
			builder.HasMany(x => x.MessageReplies)
				.WithOne(x=>x.Message)
				.HasForeignKey(x=>x.MessageId)
				.OnDelete(DeleteBehavior.Cascade);
		}
	}
}
