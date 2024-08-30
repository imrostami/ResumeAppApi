namespace ResumeAppApi.Infrustructre.Mappers;

public class BlogArticleCategoryMapper : IEntityTypeConfiguration<BlogArticleCategory>
{
	public void Configure(EntityTypeBuilder<BlogArticleCategory> builder)
	{
		builder.ToTable("ArticleCategories");
		builder.HasKey(x => x.CategoryId);
		builder.Property(x=>x.CategoryName)
			.IsRequired()
			.HasMaxLength(75);
	}
}
