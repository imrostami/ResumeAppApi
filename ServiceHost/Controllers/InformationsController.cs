namespace ServiceHost.Controllers;

[Route("api/[controller]")]
[ApiController]
public class InformationsController(IMediator mediator) : ControllerBase
{
	[HttpGet("getInformation")]
	public async Task<IActionResult> GetInformation()
	{
		var information = await mediator.Send(new GetInformationQuery());
		var response = new GetInformationResponse(information);

		if (response.Ok)
			return Ok(response);

		return NotFound(response);
	}

	[HttpPost("createInformation")]
	[Authorize]
	public async Task<IActionResult> CreateInformation(CreateInformationCommand command)
	{
		var createInformationResult = await mediator.Send(command);
		var response = new CreateInformationResponse(createInformationResult);


		if(response.Ok) 
			return Ok(response);

		return BadRequest(response);

	}


	[HttpPut("editInformation")]
	[Authorize]
	public async Task<IActionResult> EditInformation(UpdateInformationCommand command)
	{
		var updateInformationResult = await mediator.Send(command);
		var response = new UpdateInformationResponse(updateInformationResult);

		if (response.Ok)
			return Ok(response);


		return NotFound(response);
	}


	[HttpDelete("deleteInformation")]
	[Authorize]
	public async Task<IActionResult> DeleteInformation(DeleteInformationCommand command)
	{
		var deleteInformationRsult = await mediator.Send(command);
		var response = new DeleteInformationResponse(deleteInformationRsult);

		if (response.Ok)
			return Ok(response);

		return NotFound(response);

	}


	[HttpPatch("changeImage")]
	[Authorize]
	public async Task<IActionResult> ChangeProfilePicture([FromForm] ChangeInformationImageCommand command)
	{
		var changeInformationResult = await mediator.Send(command);
		var response = new ChangeInformationImageResponse(changeInformationResult);

		if (response.Ok)
			return Ok(response);


		return NotFound(response);

	}
}
