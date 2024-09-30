using ResumeAppApi.Application.WorkSamples.Commands.UpdateWorkSample;

namespace ServiceHost.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class WorkSampleController(IMediator mediator) : ControllerBase
	{
		[HttpGet("getWorkSamples")]
		public async Task<IActionResult> GetWorkSamples()
		{
			var workSamples = await mediator.Send(new GetWorkSamplesQuery());
			var response = new GetWorkSamplesResponse(workSamples);
			
			return Ok(response);
		}



		[HttpGet("getWorkSample")]
		public async Task<IActionResult> GetWorkSampleById(GetWorkSampleByIdQuery query)
		{
			var workSample = await mediator.Send(query);
			var response = new GetWorkSampleResponse(workSample);

			if(response.Ok)
				return Ok(response);

			return NotFound(response);

		}



		[HttpGet("getCategoryWorkSamples")]
		public async Task<IActionResult> GetCategroyWorkSamples(GetWorkSampleByCategoryIdQuery query)
		{
			var workSamples = await mediator.Send(query);
			var response = new GetWorkSamplesResponse(workSamples);

			if(response.Ok) 
				return Ok(query);

			return NotFound(response);
		}


		[Authorize]
		[HttpPost("createWorkSample")]
		public async Task<IActionResult> CreateWorkSample([FromForm] CreateWorkSampleCommand command)
		{
			var createWorkSampleResult = await mediator.Send(command);
			var response = new CreateWorkSampleResponse(createWorkSampleResult);

			if (response.Ok)
				return Ok(response);

			return BadRequest(response);

		}


		[Authorize]
		[HttpDelete("deleteWorkSample")]
		public async Task<IActionResult> DeleteWorkSample(DeleteWorkSampleCommand command)
		{
			var deleteWorkSampleResult = await mediator.Send(command);
			var response = new DeleteWorkSampleResponse(deleteWorkSampleResult);

			if (response.Ok)
				return Ok(response);

			return NotFound(response);
		}


		[Authorize]
		[HttpPut("changeImage")]
		public async Task<IActionResult> ChangeImage([FromForm] ChangeWorkSampleImageCommand command)
		{
			var changeImageResult = await mediator.Send(command);
			var response = new ChangeImageResponse(changeImageResult);

			if(response.Ok)
				return Ok(response);

			return NotFound(response);

		}

		[Authorize]
		[HttpPost("editWorkSample")]

		public async Task<IActionResult> EditWorkSample(UpdateWorkSampleCommand command)
		{
			var editWorkSampleResult = await mediator.Send(command);
			var response = new EditWorkSampleResponse(editWorkSampleResult);

			if (response.Ok)
				return Ok(response);

			return NotFound(response);
		}


		




	}
}
