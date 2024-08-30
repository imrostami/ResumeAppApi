
namespace ResumeAppApi.Infrustructre.Mappers;

public class SkillMapper : IEntityTypeConfiguration<Skill>
{
	public void Configure(EntityTypeBuilder<Skill> builder)
	{
		builder.ToTable("Skills");
		builder.HasKey(x => x.SkillId);

		builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
	}
}
