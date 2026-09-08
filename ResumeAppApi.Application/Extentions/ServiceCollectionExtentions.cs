namespace ResumeAppApi.Application.Extentions;

public static class ServiceCollectionExtentions
{
	public static void AddApplication(this IServiceCollection services)
	{
		var assembely = typeof(ServiceCollectionExtentions).Assembly;


		services.AddAutoMapper(mapperConfig => 
			mapperConfig.AddMaps(assembely))
			.AddValidatorsFromAssembly(assembely)
			.AddFluentValidationAutoValidation()
			.AddMediatR(mediatr=>
			mediatr.RegisterServicesFromAssembly(assembely));
		
			
	}
}
