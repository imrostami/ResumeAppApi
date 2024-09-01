
using Microsoft.AspNetCore.Identity;


namespace ResumeAppApi.Infrustructre.Extentions
{
	public static class ServiceCollectionExtentions
	{
		public static void AddInfrustructre(this IServiceCollection services, IConfiguration configuration)
		{
			var connectionString = configuration.GetConnectionString("ResumeDb");

			services.AddDbContext<AppDbContext>(options =>
			options.UseMySQL(connectionString));

			services.AddIdentityApiEndpoints<User>()
			.AddEntityFrameworkStores<AppDbContext>();

			services.AddScoped<IMessageRepository, MessageRepository>()
				.AddScoped<ICertificateRepository, CertificateRepository>()
				.AddScoped<IContactInfoRepository, ContactInfoRepository>()
				.AddScoped<IEducationRepository, EducationRepository>()
				.AddScoped<IInformationRepository, InformationRepository>()
				.AddScoped<ISkillRepository, SkillRepository>()
				.AddScoped<IWorkTipsRepository, WorkTipsRepository>()
				.AddScoped<IWorkSampleRepository, WorkSampleRepository>()
				.AddScoped<IWorkSampleCategoryRepository, WorkSampleCategoryRepository>()
				.AddScoped<IBlogArticleRepository, BlogArticleRepository>()
				.AddScoped<IBlogArticleCategoryRepository, BlogArticleCategoryRepository>();

			
		}
	}
}
