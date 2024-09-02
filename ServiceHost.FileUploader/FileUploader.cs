using Microsoft.AspNetCore.Http;

namespace ServiceHost.FileUploader
{
	public class FileUploader(string enviromentPath) : IFileUploader
	{
		public async Task<string> UploadDefault(IFormFile file, AppDirectories directory, string path) 
			=> await Upload(file, directory.ToString(), path);


		public async Task<string> Upload(IFormFile file, string rootDirectory, string path)
		{

			if (file is null) return "";


			var randomId = Guid.NewGuid().ToString("N").ToLower();
			var directoryPath = Path.Combine(enviromentPath, rootDirectory,path, randomId);

			if (!Directory.Exists(directoryPath))
				Directory.CreateDirectory(directoryPath);

			var fileName = $"{DateTime.Now.ToString("yyyyMMddTHHmmss")}{Guid.NewGuid().ToString("N")}{Path.GetExtension(file.FileName)}";
			var saveFilePath = Path.Combine(directoryPath, fileName);

			using var output = File.Create(saveFilePath);
			await file.CopyToAsync(output);
			return Path.Combine(rootDirectory,path,randomId,fileName).Replace(@"\", @"/");


		}
	}
}
