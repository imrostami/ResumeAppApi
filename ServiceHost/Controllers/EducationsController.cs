namespace ServiceHost.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EducationsController(IMediator mediator) : ControllerBase
{
	[HttpGet("getEducations")]
	public async Task<IActionResult> GetEducations()
	{
		var educations = await mediator.Send(new GetEducationsQuery());
		var response = new GetEducationsResponse(educations);

		return Ok(response);
		
	}

	[HttpGet("getEducation")]
	public async Task<IActionResult> GetEducation(GetEducationByIdQuery query)
	{
		var education = await mediator.Send(query);
		var response = new GetEducationResponse(education);



		return Ok(response);
	}


	[HttpPost("createEducation")]
	[Authorize]
	public async Task<IActionResult> CreateEducation(CreateEducationCommand command)
	{
		var createEducationResult = await mediator.Send(command);
		var response = new CreateEducationResponse(createEducationResult);

		if (response.Ok)
			return Ok(response);

		return NotFound(response);
			
	}



	[HttpDelete("deleteEducation")]
	[Authorize]
	public async Task<IActionResult> DeleteEducation(DeleteEducationCommand command)
	{
		var deleteEducationResult = await mediator.Send(command);
		var response = new DeleteEducationResponse(deleteEducationResult);

		if (response.Ok)
			return Ok(response);

		return NotFound(response);
	}


	[HttpPut("editEducation")]
	[Authorize]
	public async Task<IActionResult> UpdateEducation(UpdateEducationCommand command)
	{
		var updateEducationResult = await mediator.Send(command);
		var response = new UpdateEducationResponse(updateEducationResult);


		if (response.Ok)
			return Ok(response);

		return NotFound(response);
	}


}
