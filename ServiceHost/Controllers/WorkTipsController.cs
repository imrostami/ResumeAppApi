namespace ServiceHost.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WorkTipsController(IMediator mediator) : ControllerBase
{
	[HttpGet("getWorkTips")]
	public async Task<IActionResult> GetWorkTips()
	{
		var workTips = await mediator.Send(new GetWorkTipsQuery());
		var response = new GetWorkTipsResponse(workTips);

		return Ok(response);
	}

	[HttpGet("getWorkTip")]
	public async Task<IActionResult> GetWorkTip(GetWorkTipByIdQuery query)
	{
		var getWorkTipResult = await mediator.Send(query);
		var response = new GetWorkTipResponse(getWorkTipResult);

		if (response.Ok)
			return Ok(response);

		return NotFound(response);
	}



	[Authorize]
	[HttpPost("createWorkTip")]
	public async Task<IActionResult> CreateWorkTip([FromForm] CreateWorkTipCommand command)
	{
		var createWorkTipResult = await mediator.Send(command);
		var response = new CreateWorkTipResponse(createWorkTipResult);

		if (response.Ok)
			return Ok(response);

		return BadRequest(response);
	}



	[Authorize]
	[HttpDelete("deleteWorkTip")]
	public async Task<IActionResult> DeleteWorkTip(DeleteWorkTipCommand command) 
	{
		var deleteWorkTipResult = await mediator.Send(command);
		var response = new DeleteWorkTipResponse(deleteWorkTipResult);

		if (response.Ok)
			return Ok(response);

		return NotFound(response);
	}

	[HttpPut("editWorkTip")]
	public async Task<IActionResult> UpdateWorkTip(UpdateWorkTipCommand command)
	{
		var updateWorkTipResult = await mediator.Send(command);
		var response = new UpdateWorkTipResponse(updateWorkTipResult);

		if (response.Ok)
			return Ok(response);

		return NotFound(response);
	}

	[HttpPatch("changeWorkTipIcon")]
	public async Task<IActionResult> ChangeWorkTipIcon([FromForm] ChangeWorkTipIconCommand command)
	{
		var changeWorkTipResult = await mediator.Send(command);
		var response = new ChangeWorkTipIconResponse(changeWorkTipResult);

		if (response.Ok)
			return Ok(response);

		return NotFound(response);
	}


}
