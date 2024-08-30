﻿namespace ServiceHost.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class MessagesController(IMediator mediator) : ControllerBase
{
	[HttpGet("getMessages")]
	public async Task<GetMessagesResponse> GetMessagesAsync()
	{
		var messages = await mediator.Send(new GetMessagesQuery());
		return new GetMessagesResponse(true, messages);

	}

	[HttpGet("getUnreadMessages")]
	public async Task<GetUnReadMessageResponse> GetUnReadMessagesAsync()
	{
		var unReadMessages = await mediator.Send(new GetUnReadMessagesQuery());
		return new GetUnReadMessageResponse(unReadMessages);
	}

	[HttpGet("getUnReadCount")]
	public async Task<GetUnReadMessageCountResponse> GetUnReadMessageCount()
	{
		var unReadMessageCount = await mediator.Send(new GetUnReadMessagesCountQuery());
		return new GetUnReadMessageCountResponse(true, unReadMessageCount);

	}

	[HttpPost("createMessage")]
	public async Task<IActionResult> CreateMessageAsync(CreateMessageCommand command)
	{
		var createdMessage = await mediator.Send(command);

		var response = new CreateMessageResponse(
			ok: true,
			message: "پیام با موفقیت ثبت شد",
			createdMessage.MessageId);

		return Ok(response);
	}

	[HttpPatch("setMessageRead")]
	public async Task<IActionResult> SetMessageReadAsync(ReadMessageByIdQuery command)
	{
		var result = await mediator.Send(command);
		var response = new ReadMessageResponse(result);

		if (response.Ok)
			return Ok(response);

		return BadRequest(response);
	}
	[HttpGet("getMessage")]
	public async Task<IActionResult> GetMessageById(GetMessageByIdQuery query)
	{
		var message = await mediator.Send(query);

		var response = new GetMessageResponse(message);

		if (response.Ok)
			return Ok(response);

		return NotFound(response);


	}

	[HttpDelete("deleteMessage")]
	public async Task<IActionResult> DeleteMessageAsync(RemoveMessageByIdCommand command)
	{
		var result = await mediator.Send(command);
		var response = new DeleteMessageResponse(result);

		if (response.Ok)
			return Ok(response);
		return NotFound(response);
	}
}
