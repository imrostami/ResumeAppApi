using ResumeAppApi.Application.WorkSampleCategories.Dtos;
using ServiceHost.Responses;
using System.Text.Json.Serialization;

namespace ServiceHost.ApiResponses.WorkSampleCategoreis
{
	public class CreateWorkSampleCategroyResponse(WorkSampleCategoryDto workSampleCategory) : IResponse<WorkSampleCategoryDto>
	{
		public bool Ok => workSampleCategory != null;

		public WorkSampleCategoryDto Result => workSampleCategory;

		[JsonIgnore]
		public string Message => Ok ? ResponseMessage.Added() :
			ResponseMessage.Duplicate();
	}
}
