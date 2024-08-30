using ResumeAppApi.Application.BlogCategories.Dtos;
using ResumeAppApi.Domain.Entities.BlogAgg;

namespace ResumeAppApi.Application.Blogs.Dtos;

public class BlogDto
{
	public int Id { get; set; }
	public string Title { get; set; }
	public string Body { get; set; }
	public int CategoryId { get; set; }
	public BlogCategoryDto Category { get; set; }
	public string CreationTime { get; set; }
    public string CreationTimeLongDate { get; set; }
    public string LastUpdateTime { get; set; }
    public string LastUpdateTimeLongDate { get; set; }
    public string Picture { get; set; }
	public string PircutrAlt { get; set; }
}
