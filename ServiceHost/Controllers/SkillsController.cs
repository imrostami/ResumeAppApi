namespace ServiceHost.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SkillsController(IMediator mediator) : ControllerBase
{

	[HttpGet("getSkills")]
	public async Task<IActionResult> GetSkills()
	{
		var skills = await mediator.Send(new GetSkillsQuery());
		var response = new GetSkillsResponse(skills);


		return Ok(response);
	}

	[HttpGet("getSkill")]
	public async Task<IActionResult> GetSkillById(GetSkillByIdQuery query)
	{
		var skillDto = await mediator.Send(query);
		var response = new GetSkillResponse(skillDto);

		if(response.Ok)
			return Ok(response);

		return NotFound(response);
	}



	[Authorize]
	[HttpPost("createSkill")]
	public async Task<IActionResult> CreateSkill(CreateSkillCommand command)
	{
		var commandResult = await mediator.Send(command);
		var response = new CreateSkillResponse(commandResult);

		if (response.Ok)
			return Ok(response);

		return BadRequest(response);
	}


	[Authorize]
	[HttpPut("editSkill")]
	public async Task<IActionResult> UpdateSkill(UpdateSkillCommand command)
	{
		var updateSkillResult = await mediator.Send(command);
		var response = new UpdateSkillResponse(updateSkillResult);

		if (response.Ok)
			return Ok(response);

		return NotFound(response);
	}


	[Authorize]
	[HttpDelete("deleteSkill")]
	public async Task<IActionResult> DeleteSkill(DeleteSkillCommand command)
	{
		var deleteSkillResult = await mediator.Send(command);
		var response = new DeleteSkillResponse(deleteSkillResult);

		if(response.Ok)
			return Ok(response);
		return NotFound(response);
	}

	


}
