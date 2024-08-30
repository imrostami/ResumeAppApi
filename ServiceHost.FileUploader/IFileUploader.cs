using Microsoft.AspNetCore.Http;

namespace ServiceHost.FileUploader;

public interface IFileUploader
{
	Task<string> Upload(IFormFile file, string rootDirectory, string path);
	Task<string> UploadDefault(IFormFile file, AppDirectories directory, string path);
	
}
