using ResumeAppApi.Application.WorkTips.Dtos;
using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.WorkTips
{
	public class CreateWorkTipResponse(WorkTipDto workTip) : IResponse<WorkTipDto>
	{
		public bool Ok => workTip != null;
		public WorkTipDto Result => workTip;

		public string Message => Ok ? ResponseMessage.Added() :
			ResponseMessage.Broken();
	}
}
