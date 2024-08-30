
namespace ResumeAppApi.Infrustructre.Mappers;

public class EducationMapper : IEntityTypeConfiguration<Education>
{
	public void Configure(EntityTypeBuilder<Education> builder)
	{
		builder.HasKey(x => x.Id);
		builder.ToTable("Educations");

		builder.Property(x => x.University).HasMaxLength(100).IsRequired();
		builder.Property(x => x.Title).HasMaxLength(100).IsRequired();
		builder.Property(x => x.Description).HasMaxLength(200).IsRequired();
		builder.Property(x => x.StartDate).IsRequired();
		builder.Property(x => x.EndDate).IsRequired();
	}
}
