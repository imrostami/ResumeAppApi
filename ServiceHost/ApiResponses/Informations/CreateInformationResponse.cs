using ResumeAppApi.Application.Informations.Dtos;
using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.Informations
{
	public class CreateInformationResponse(InformationDto information) : IResponse<InformationDto>
	{
		public bool Ok => information != null;

		public InformationDto? Result => information;


		public string Message => Ok ? ResponseMessage.Added() :
			ResponseMessage.Duplicate();
	}
}
