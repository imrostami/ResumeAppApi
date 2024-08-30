

namespace ServiceHost.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class WorkSampleCategoriesController(IMediator mediator) : ControllerBase
	{
		[HttpGet("getCategories")]
		public async Task<IActionResult> GetCategories()
		{
			var categories = await mediator.Send(new GetWorkSampleCategoriesQuery());
			var response = new GetWorkSampleCategoriesResponse(categories);
				return Ok(response);
			
		}

		[HttpPost("createCategroy")]
		public async Task<IActionResult> CreateWorkSampleCategory(CreateWorkSampleCategoryCommand command)
		{
			var createCategoryResult = await mediator.Send(command);
			var response = new CreateWorkSampleCategroyResponse(createCategoryResult);

			if (response.Ok)
				return Ok(response);


			return BadRequest(response);
		}

		[HttpPut("editCategory")]
		public async Task<IActionResult> UpdateCategroy(UpdateWorkSampleCategoryCommand command)
		{
			var updateCategoryResult = await mediator.Send(command);
			var response = new UpdateWorkSampleCategoryResponse(updateCategoryResult);

			if (response.Ok)
				return Ok(response);


			return NotFound(response);

		}

		[HttpDelete("deleteCategory")]
		public async Task<IActionResult> DeleteCategroy(DeleteWorkSampleCategoryCommand command)
		{
			var deleteWorkSampleResult = await mediator.Send(command);
			var response = new DeleteWorkSampleCategoryResponse(deleteWorkSampleResult);

			if (response.Ok)
				return Ok(response);

			return NotFound(response);
		}
	}
}
