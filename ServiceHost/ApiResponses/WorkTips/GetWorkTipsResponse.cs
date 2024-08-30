using ResumeAppApi.Application.WorkTips.Dtos;
using ServiceHost.Responses;
using System.Text.Json.Serialization;

namespace ServiceHost.ApiResponses.WorkTips
{
	public class GetWorkTipsResponse(IEnumerable<WorkTipDto> workTips) : IResponse<IEnumerable<WorkTipDto>>
	{
		public bool Ok => workTips != null;

		public IEnumerable<WorkTipDto> Result => workTips;


		[JsonIgnore]
		public string Message => string.Empty;
	}
}
