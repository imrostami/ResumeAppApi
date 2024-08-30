using ResumeAppApi.Application.WorkSampleCategories.Dtos;

namespace ResumeAppApi.Application.WorkSampleCategories.Queries.GetWorkSampleCategoryById;

public class GetWorkSampleCategoryByIdQueryHandler(IWorkSampleCategoryRepository workSampleCategoryRepository,
	IMapper mapper) : IRequestHandler<GetWorkSampleCategoryByIdQuery, WorkSampleCategoryDto>
{
	public async Task<WorkSampleCategoryDto?> Handle(GetWorkSampleCategoryByIdQuery request, CancellationToken cancellationToken)
	{
		var workSampleCategory = await workSampleCategoryRepository.GetBy(request.Id);

		if (workSampleCategory is null)
			return null;

		return mapper.Map<WorkSampleCategoryDto>(workSampleCategory);
		
	}
}
