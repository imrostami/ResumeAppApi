
namespace ResumeAppApi.Infrustructre.Mappers;

public class WorkTipsMapper : IEntityTypeConfiguration<WorkTip>
{
	public void Configure(EntityTypeBuilder<WorkTip> builder)
	{
		builder.ToTable("WorkTips");
		builder.HasKey(x => x.TipId);
		
		builder.Property(x=>x.Title).IsRequired()
			.HasMaxLength(100);

		builder.Property(x=>x.Caption)
			.IsRequired()
			.HasMaxLength(250);

		builder.Property(x => x.Icon).IsRequired();

	}
}
