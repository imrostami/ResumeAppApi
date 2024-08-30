using Microsoft.AspNetCore.Http;

namespace ResumeAppApi.Application.Blogs.Commands.UpdateBlogImage
{
	public class UpdateBlogImageCommand : IRequest<bool>
	{
        public int Id { get; set; }
		public IFormFile Picture { get; set; }
		public string PircutrAlt { get; set; }
	}
}
