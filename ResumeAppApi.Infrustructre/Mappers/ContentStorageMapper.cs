using ResumeAppApi.Domain.Entities.ContentStorageAgg;

namespace ResumeAppApi.Infrustructre.Mappers;

public class ContentStorageMapper : IEntityTypeConfiguration<ContentStorage>
{
	public void Configure(EntityTypeBuilder<ContentStorage> builder)
	{
		builder.ToTable("staticStorage");
		builder.HasKey(x => x.StorageId);
		builder.Property(x => x.Content)
			.IsRequired();
		builder.Property(x => x.Name)
			.IsRequired()
			.HasMaxLength(100);
	}
}
