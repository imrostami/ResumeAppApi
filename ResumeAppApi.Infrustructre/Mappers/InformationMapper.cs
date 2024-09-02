
namespace ResumeAppApi.Infrustructre.Mappers;

public class InformationMapper : IEntityTypeConfiguration<Information>
{
	public void Configure(EntityTypeBuilder<Information> builder)
	{
		builder.ToTable("Informations");
		builder.HasKey(x => x.InformationId);

		builder.Property(x => x.About).HasMaxLength(3500).IsRequired();
		builder.Property(x => x.FirstName).HasMaxLength(60).IsRequired();
		builder.Property(x => x.LastName).HasMaxLength(100).IsRequired();
		builder.Property(x => x.Birthday).HasMaxLength(50).IsRequired();
		builder.Property(x => x.Languages).HasMaxLength(80).IsRequired();
		builder.Property(x => x.Nationality).HasMaxLength(50).IsRequired();
		builder.Property(x => x.Address).HasMaxLength(80).IsRequired(false);
		builder.Property(x=>x.PictureAlt).HasMaxLength(100).IsRequired(false);
		builder.Property(x => x.Picture).IsRequired(false);
		builder.Property(x => x.ShortAbout).IsRequired().HasMaxLength(130);
	}
}
