namespace ResumeAppApi.Infrustructre.Mappers;

public class ContactInfoMapper : IEntityTypeConfiguration<ContactInfo>
{
	public void Configure(EntityTypeBuilder<ContactInfo> builder)
	{
		builder.ToTable("Contacts");
		builder.HasKey(x => x.ContactId);
		
		builder.Property(x=>x.ContactName).IsRequired()
			.HasMaxLength(50);
		
		builder.Property(x => x.ContactValue)
			.IsRequired()
			.HasMaxLength(150);
	}
}
