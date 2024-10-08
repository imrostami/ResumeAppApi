﻿using ResumeAppApi.Application.BlogCategories.Commands.CreateBlogCategory;
using ResumeAppApi.Application.BlogCategories.Commands.DeleteBlogCategory;
using ResumeAppApi.Application.BlogCategories.Commands.UpdateBlogCategory;
using ResumeAppApi.Application.BlogCategories.Queries.GetBlogCategories;
using ResumeAppApi.Application.BlogCategories.Queries.GetBlogCategoryById;
using ResumeAppApi.Application.Blogs.Commands.DeleteBlog;
using ResumeAppApi.Application.Blogs.Commands.UpdateBlog;
using ResumeAppApi.Application.Blogs.Commands.UpdateBlogImage;
using ResumeAppApi.Application.Blogs.Queries.GetBlogById;
using ResumeAppApi.Application.Blogs.Queries.GetBlogs;
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



		[Authorize]
		[HttpPost("createBlogCategory")]
		public async Task<IActionResult> CreateBlogCategory(CreateBlogCategoryCommand command)
		{
			var createBlogCategoryResult = await mediator.Send(command);
			var response = new CreateBlogCategoryResponse(createBlogCategoryResult);

			if (response.Ok)
				return Ok(response);

			return BadRequest(response);
			
		}


		[Authorize]
		[HttpDelete("deleteBlogCategory")]
		public async Task<IActionResult> DeleteBlogCategory(DeleteBlogCategoryCommand command)
		{
			var deleteCategoryResult = await mediator.Send(command);
			var response = new DeleteBlogCategoryResponse(deleteCategoryResult);

			if (response.Ok)
				return Ok(response);


			return NotFound(response);
		}


		[Authorize]
		[HttpPut("editBlogCategpry")]
		public async Task<IActionResult> EditBlogCategory(UpdateBlogCategoryCommand command)
		{
			var updateCategoryResult = await mediator.Send(command);
			var response = new UpdateBlogCategoryResponse(updateCategoryResult);

			if (response.Ok)
				return Ok(response);

			return NotFound(response);
		}

		[HttpGet("getBlogs")]
		public async Task<IActionResult> GetBlogs()
		{
			var blogs = await mediator.Send(new GetBlogsQuery());
			var response = new GetBlogsResponse(blogs);
			return Ok(response);
		}

		[HttpGet("getBlog")]
		public async Task<IActionResult> GetBlog(GetBlogByIdQuery query)
		{
			var blog = await mediator.Send(query);
			var response = new GetBlogResponse(blog);

			if (response.Ok)
				return Ok(response);

			return NotFound(response);
		}

		[Authorize]
		[HttpPost("createBlog")]
		public async Task<IActionResult> CreateBlog()
		{
			return Ok();
		}

		[HttpPatch("editBlogImage")]
		public async Task<IActionResult> EditBlogImage(UpdateBlogImageCommand command)
		{
			var updateBlogImageResult = await mediator.Send(command);
			var response = new UpdateBlogImageResponse(updateBlogImageResult);

			if (response.Ok)
				return Ok(response);

			return NotFound(response);

		}


		[Authorize]
		[HttpPut("updateBlog")]
		public async Task<IActionResult> UpdateBlog(UpdateBlogCommand command)
		{
			var updateBlogResult = await mediator.Send(command);
			var response = new UpdateBlogResponse(updateBlogResult);

			if (response.Ok)
				return Ok(response);

			return NotFound(response);
			
		}



		[Authorize]
		[HttpDelete("deleteBlog")]
		public async Task<IActionResult> DeleteBlog(DeleteBlogCommand command)
		{
			var deleteBlogResult = await mediator.Send(command);
			var response = new DeleteBlogResponse(deleteBlogResult);

			if (response.Ok)
				return Ok(response);

			return NotFound(response);
		}
	}
}
