using Microsoft.AspNetCore.Http;
using ResumeAppApi.Application.BlogCategories.Dtos;
using ResumeAppApi.Application.Blogs.Dtos;

namespace ResumeAppApi.Application.Blogs.Commands.CreateBlog;

public class CreateBlogCommand : IRequest<BlogDto>
{
	public string Title { get; set; }
	public string Body { get; set; }
	public int CategoryId { get; set; }
	public IFormFile Picture { get; set; }
	public string PircutrAlt { get; set; }
}
