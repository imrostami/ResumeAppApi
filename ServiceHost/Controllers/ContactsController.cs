namespace ServiceHost.Controllers;

[Route("api/[controller]")]
[ApiController]

public class ContactsController(IMediator mediator) : ControllerBase
{
	[HttpGet("getAllContacts")]
	public async Task<GetAllContactsResponse> GetAllContacts()
	{
		var contactInfos = await mediator.Send(new GetAllContactQuery());
		var response = new GetAllContactsResponse(contactInfos);
		return response;
	}



	[HttpGet("findByName")]
	public async Task<IActionResult> GetContact(GetContactByNameQuery query)
	{
		var contact = await mediator.Send(query);

		var response = new GetContactResponse(contact);

		if (response.Ok)
			return Ok(response);
		return NotFound(response);


	}


	[HttpGet("findById")]
	public async Task<IActionResult> GetContactById(GetContactByIdQuery query)
	{
		var contact = await mediator.Send(query);
		var response = new GetContactResponse(contact);

		if (response.Ok)
			return Ok(response);

		return NotFound(response);
	}

	[Authorize]
	[HttpPost("createContactInfo")]
	public async Task<IActionResult> CreateContactInfo(CreateContactInfoCommand command)
	{
		var createContactResult = await mediator.Send(command);
		var response = new CreateContactInfoResponse(createContactResult);

		if(response.Ok) 
			return Ok(response);
		return BadRequest(response);
	}

	[Authorize]
	[HttpPut("editContactInfo")]
	public async Task<IActionResult> UpdateContact(UpdateContactInfoCommand command)
	{
		var updateResult = await mediator.Send(command);
		var response = new UpdateContactInfoResponse(updateResult);

		if (response.Ok)
			return Ok(response);

		return NotFound(response);
	}

	[Authorize]
	[HttpDelete("removeContactInfo")]
	public async Task<IActionResult> RemoveContact(RemoveContactInfoCommand command)
	{
		var removeResult = await mediator.Send(command);
		var response = new RemoveContactInfoResponse(removeResult);
		
		
		if (response.Ok)
			return Ok(response);

		return NotFound(response);
	}
}
