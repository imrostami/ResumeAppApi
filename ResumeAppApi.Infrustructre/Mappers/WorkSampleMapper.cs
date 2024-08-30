
namespace ResumeAppApi.Infrustructre.Mappers;

public class WorkSampleMapper : IEntityTypeConfiguration<WorkSample>
{
	public void Configure(EntityTypeBuilder<WorkSample> builder)
	{
		builder.ToTable("WorkSamples");
		builder.HasKey(x => x.SampleId);
		
		builder.Property(x => x.Name).IsRequired().
			HasMaxLength(80);
		
		builder.Property(x => x.Description).IsRequired()
			.HasMaxLength(650);

		builder.Property(x => x.PictureAlt).IsRequired(false)
			.HasMaxLength(100);

		builder.Property(x => x.Picture).IsRequired(false);

		builder.HasOne(x => x.WorkSampleCategory)
			.WithMany()
			.HasForeignKey(x=>x.CategoryId);
	}
}
