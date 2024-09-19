
using ResumeAppApi.Application.WorkSampleCategories.Dtos;
using ResumeAppApi.Domain.Entities.WorkSampleAgg;

namespace ResumeAppApi.Application.WorkSampleCategories.Commands.CreateWorkSampleCategory;

public class CreateWorkSampleCategoryCommandHandler(IWorkSampleCategoryRepository workSampleCategoryRepository,
	IMapper mapper) : IRequestHandler<CreateWorkSampleCategoryCommand, WorkSampleCategoryDto>
{
	public async Task<WorkSampleCategoryDto?> Handle(CreateWorkSampleCategoryCommand request, CancellationToken cancellationToken)
	{
		var getWorkSampleResult = await workSampleCategoryRepository.GetBy(request.CategoryName);

		if (getWorkSampleResult is not null)
			return null;


		var category = mapper.Map<WorkSampleCategory>(request);
		var createWorkSampleResult = await workSampleCategoryRepository.CreateAsync(category);
		return mapper.Map<WorkSampleCategoryDto>(createWorkSampleResult);

	}
}
