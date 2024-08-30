
namespace ResumeAppApi.Infrustructre.Mappers;

public class CertificateMapper : IEntityTypeConfiguration<Certificate>
{
	public void Configure(EntityTypeBuilder<Certificate> builder)
	{
		builder.ToTable("Certificates");
		builder.HasKey(x => x.CertificateId);

		builder.Property(x => x.Issuer)
			.IsRequired()
			.HasMaxLength(100);

		builder.Property(x => x.ImageAlt)
			.IsRequired()
			.HasMaxLength(75);

		builder.Property(x => x.Caption)
			.IsRequired()
			.HasMaxLength(200);

		builder.Property(x => x.Name)
			.IsRequired()
			.HasMaxLength(120);

		builder.Property(x => x.Image)
			.IsRequired(false);



	}
}
