using ResumeAppApi.Application.ContentStorages.Commands.CreateStorage;
using ResumeAppApi.Application.ContentStorages.Commands.DeleteStorage;
using ResumeAppApi.Application.ContentStorages.Commands.UpdateStorage;
using ResumeAppApi.Application.ContentStorages.Queries.GetStorageById;
using ResumeAppApi.Application.ContentStorages.Queries.GetStorageByName;
using ResumeAppApi.Application.ContentStorages.Queries.GetStorages;
using ServiceHost.ApiResponses.ContentStorages;

namespace ServiceHost.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ContentStoreController(IMediator mediator) : ControllerBase
	{
		[HttpGet("getStores")]
		[Authorize]
		public async Task<IActionResult> GetStores()
		{
			var stores = await mediator.Send(new GetStoragesQuery());
			var response = new GetStoragesListResponse(stores);
			return Ok(response);
		}
		[HttpGet("getStore")]
		public async Task<IActionResult> GetStorage([FromQuery] GetStorageByNameQuery query)
		{
			var store = await mediator.Send(query);
			var response = new GetStorageResponse(store);

			if (response.Ok)
				return Ok(response);

			return NotFound(response);

		}

		[HttpPost("createStore")]
		[Authorize]
		public async Task<IActionResult> Create([FromForm] CreateStorageCommand command)
		{
			var createStorageResult = await mediator.Send(command);
			var response = new CreateStorageResponse(createStorageResult);

			if (response.Ok)
				return Ok(response);

			return BadRequest(response);
		}

		[HttpPut("updateStore")]
		[Authorize]
		public async Task<IActionResult> Update([FromForm] UpdateStorageCommand command)
		{
			var updateStorageResult = await mediator.Send(command);
			var response = new UpdateStorageResponse(updateStorageResult);
			if (response.Ok)
				return Ok(response);
			return BadRequest(response);
		}

		[HttpDelete("deleteStore")]
		[Authorize]
		public async Task<IActionResult> Delete(DeleteStorageCommand command)
		{
			var deleteStorageResult = await mediator.Send(command);
			var response = new DeleteStorageResponse(deleteStorageResult);
			if (response.Ok)
				return Ok(response);
			return BadRequest(response);
		}

		[HttpGet("getStoreById")]
		public async Task<IActionResult> GetStorage([FromQuery] GetStorageByIdQuery query)
		{
			var store = await mediator.Send(query);
			var response = new GetStorageResponse(store);

			if (response.Ok)
				return Ok(response);

			return NotFound(response);

		}
	}
}
