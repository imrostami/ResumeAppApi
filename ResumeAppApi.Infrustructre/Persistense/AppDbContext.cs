
namespace ResumeAppApi.Infrustructre.Persistense;

public class AppDbContext(DbContextOptions<AppDbContext> options) : IdentityDbContext<User>(options)
{
    public DbSet<Message> Messages { get; set; }
    public DbSet<Certificate> Certificates { get; set; }
    public DbSet<ContactInfo> Contacts { get; set; }
    public DbSet<Education> Educations { get; set; }
    public DbSet<Information> Informations { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<WorkTip> WorkTips { get; set; }
    public DbSet<WorkSample> WorkSamples { get; set; }
    public DbSet<WorkSampleCategory> WorkSampleCategories { get; set; }
    public DbSet<BlogArticle> BlogArticles { get; set; }
    public DbSet<BlogArticleCategory> BlogArticleCategories { get; set; }


    protected override void OnModelCreating(ModelBuilder builder)
	{
		base.OnModelCreating(builder);
		var assembely = typeof(ServiceCollectionExtentions).Assembly;
		builder.ApplyConfigurationsFromAssembly(assembely);
	}


}
