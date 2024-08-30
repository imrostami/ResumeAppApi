using Microsoft.Extensions.DependencyInjection;

namespace ServiceHost.FileUploader
{
	public static class ServiceCollectionExtention
	{
		public static void AddFileUploaderService(this IServiceCollection services,string enviromentPath)
		{
			var fileUploader = new FileUploader(enviromentPath);
			services.AddTransient<IFileUploader, FileUploader>(x=>fileUploader);
		}

	}
}
