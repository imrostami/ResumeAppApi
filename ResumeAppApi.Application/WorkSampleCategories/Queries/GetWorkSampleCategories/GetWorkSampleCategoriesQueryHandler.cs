using ResumeAppApi.Application.WorkSampleCategories.Dtos;

namespace ResumeAppApi.Application.WorkSampleCategories.Queries.GetWorkSampleCategories;

public class GetWorkSampleCategoriesQueryHandler(IWorkSampleCategoryRepository workSampleCategoryRepository,
	IMapper mapper) : IRequestHandler<GetWorkSampleCategoriesQuery, IEnumerable<WorkSampleCategoryDto>>
{
	public async Task<IEnumerable<WorkSampleCategoryDto>> Handle(GetWorkSampleCategoriesQuery request, CancellationToken cancellationToken)
	{
		var workSampleCategories = await workSampleCategoryRepository.GetAll();
		return mapper.Map<IEnumerable<WorkSampleCategoryDto>>(workSampleCategories);
	}
}
