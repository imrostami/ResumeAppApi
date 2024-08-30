namespace ResumeAppApi.Infrustructre.Mappers;

public class BlogArticleMapper : IEntityTypeConfiguration<BlogArticle>
{
	public void Configure(EntityTypeBuilder<BlogArticle> builder)
	{
		builder.ToTable("Articles");
		builder.HasKey(x => x.ArticleId);
		builder.Property(x => x.Title)
			.IsRequired()
			.HasMaxLength(300);
		builder.Property(x => x.Body).IsRequired();

		builder.HasOne(x => x.BlogArticleCategory)
			.WithMany()
			.HasForeignKey(x => x.CategoryId);
	}
}
