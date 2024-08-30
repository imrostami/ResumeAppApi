using ResumeAppApi.Application.WorkSampleCategories.Dtos;
using ServiceHost.Responses;
using System.Text.Json.Serialization;

namespace ServiceHost.ApiResponses.WorkSampleCategoreis
{
	public class GetWorkSampleCategoriesResponse(IEnumerable<WorkSampleCategoryDto>? workSampleCategories) : IResponse<IEnumerable<WorkSampleCategoryDto>>
	{

		public bool Ok => Result != null;

		public IEnumerable<WorkSampleCategoryDto>? Result => workSampleCategories;

		[JsonIgnore]
		public string Message => throw new NotImplementedException();
	}
}
