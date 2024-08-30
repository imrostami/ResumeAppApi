
namespace ResumeAppApi.Infrustructre.Mappers;

public class WorkSampleCategoryMapper : IEntityTypeConfiguration<WorkSampleCategory>
{
	public void Configure(EntityTypeBuilder<WorkSampleCategory> builder)
	{
		builder.ToTable("WorkSampleCategories");
		builder.HasKey(x => x.CategoryId);
		builder.Property(x=>x.CategoryName).IsRequired()
			.HasMaxLength(75);
	}
}
