using Microsoft.AspNetCore.Http;

namespace ResumeAppApi.Application.Blogs.Commands.UpdateBlog
{
	public class UpdateBlogCommand : IRequest<bool>
	{
        public int Id { get; set; }
		public string Title { get; set; }
		public string Body { get; set; }
		public int CategoryId { get; set; }
	}
}
