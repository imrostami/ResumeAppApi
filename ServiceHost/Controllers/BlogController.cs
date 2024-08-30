using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResumeAppApi.Application.BlogCategories.Commands.CreateBlogCategory;
using ResumeAppApi.Application.BlogCategories.Commands.DeleteBlogCategory;
using ResumeAppApi.Application.BlogCategories.Commands.UpdateBlogCategory;
using ResumeAppApi.Application.BlogCategories.Queries.GetBlogCategories;
using ResumeAppApi.Application.BlogCategories.Queries.GetBlogCategoryById;
using ServiceHost.ApiResponses.Blogs;

namespace ServiceHost.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BlogController(IMediator mediator) : ControllerBase
	{
		[HttpGet("getBlogCategories")]
		public async  Task<IActionResult> GetBlogCategories()
		{
			var categories = await mediator.Send(new GetBlogCategoriesQuery());
			var response = new GetBlogCategoriesResponse(categories);
			return Ok(response);


		}

		[HttpGet("getBlogCategory")]
		public async Task<IActionResult> GetBlogCategory(GetBlogCategoryByIdQuery query)
		{
			var getCategoryResult = await mediator.Send(query);
			var response = new GetBlogCategoryResponse(getCategoryResult);

			if(response.Ok)
				return Ok(response);

			return NotFound(response);
		}

		[HttpPost("createBlogCategory")]
		public async Task<IActionResult> CreateBlogCategory(CreateBlogCategoryCommand command)
		{
			var createBlogCategoryResult = await mediator.Send(command);
			var response = new CreateBlogCategoryResponse(createBlogCategoryResult);

			if (response.Ok)
				return Ok(response);

			return BadRequest(response);
			
		}

		[HttpDelete("deleteBlogCategory")]
		public async Task<IActionResult> DeleteBlogCategory(DeleteBlogCategoryCommand command)
		{
			var deleteCategoryResult = await mediator.Send(command);
			var response = new DeleteBlogCategoryResponse(deleteCategoryResult);

			if (response.Ok)
				return Ok(response);


			return NotFound(response);
		}

		[HttpPut("editBlogCategpry")]
		public async Task<IActionResult> EditBlogCategory(UpdateBlogCategoryCommand command)
		{
			var updateCategoryResult = await mediator.Send(command);
			var response = new UpdateBlogCategoryResponse(updateCategoryResult);

			if (response.Ok)
				return Ok(response);

			return NotFound(response);
		}




	}
}
