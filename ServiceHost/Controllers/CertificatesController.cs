namespace ServiceHost.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CertificatesController(IMediator mediator,
	IFileUploader fileUploader) : ControllerBase
{
	[HttpGet("getCertificates")]
	public async Task<IActionResult> GetCertificates()
	{
		var certificates = await mediator.Send(new GetCertificatesQuery());
		var response = new GetCertificatesResponse(certificates);

		return Ok(response);

	}

	[HttpGet("getCertificate")]
	public async Task<IActionResult> GetCertificateById(GetCertificateByIdQuery query)
	{
		var getCertificateResult = await mediator.Send(query);
		var response = new GetCertificateByIdResponse(getCertificateResult);

		if (response.Ok)
			return Ok(response);

		return NotFound(response);
	}


	[Authorize]
	[HttpPost("createCertificate")]
	public async Task<IActionResult> CreateCertificate([FromForm] CreateCertificateCommand command)
	{
		var createCertificateResult = await mediator.Send(command);

		var response = new CreateCertificateResponse(createCertificateResult);

		if(response.Ok)
			return Ok(response);

		return BadRequest(response);
	}

	[Authorize]
	[HttpPut("editCertificate")]
	public async Task<IActionResult> UpdateCertificate(UpdateCertificateCommand command)
	{
		var updateCertificateResult = await mediator.Send(command);
		var response = new UpdateCertificateResponse(updateCertificateResult);

		if (response.Ok)
			return Ok(response);

		return NotFound(response);
	}


	[Authorize]
	[HttpPatch("changeCertificateImage")]
	public async Task<ActionResult> ChangeCertificateImage([FromForm]ChangeCertificateImageCommand command)
	{
		var updateCertificateResult = await mediator.Send(command);
		var response = new ChangeCertificateImageResponse(updateCertificateResult);

		if (response.Ok)
			return Ok(response);


		return NotFound(response);
	}


	[Authorize]
	[HttpDelete("deleteCertificate")]
	public async Task<IActionResult> DeleteCertificate(DeleteCertificateCommand command)
	{
		var deleteCertificateResult = await mediator.Send(command);
		var response = new DeleteCertificateResponse(deleteCertificateResult);

		if (response.Ok)
			return Ok(response);

		return NotFound(response);
	}




}
