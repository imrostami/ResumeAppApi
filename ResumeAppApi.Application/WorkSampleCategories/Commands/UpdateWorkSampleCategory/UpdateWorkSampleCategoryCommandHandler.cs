
namespace ResumeAppApi.Application.WorkSampleCategories.Commands.UpdateWorkSampleCategory;

public class UpdateWorkSampleCategoryCommandHandler(IWorkSampleCategoryRepository workSampleCategoryRepository,
	IMapper mapper) : IRequestHandler<UpdateWorkSampleCategoryCommand, bool>
{
	public async Task<bool> Handle(UpdateWorkSampleCategoryCommand request, CancellationToken cancellationToken)
	{
		var workSampleCategory = await workSampleCategoryRepository.GetBy(request.CategoryName);

		if (workSampleCategory != null)
			return false;


		var mappedCategory = mapper.Map(request, workSampleCategory);
		await workSampleCategoryRepository.UpdateAsync(mappedCategory);
		return true;
	}
}
