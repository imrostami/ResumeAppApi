using ResumeAppApi.Application.WorkTips.Dtos;
using ServiceHost.Responses;
using System.Text.Json.Serialization;

namespace ServiceHost.ApiResponses.WorkTips
{
	public class GetWorkTipResponse(WorkTipDto? workTip) : IResponse<WorkTipDto>
	{
		public bool Ok => workTip != null;

		public WorkTipDto Result => workTip;


		[JsonIgnore]
		public string Message => string.Empty;
	}
}
