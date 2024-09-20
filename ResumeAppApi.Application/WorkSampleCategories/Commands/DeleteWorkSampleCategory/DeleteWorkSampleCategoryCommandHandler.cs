
namespace ResumeAppApi.Application.WorkSampleCategories.Commands.DeleteWorkSampleCategory;

public class DeleteWorkSampleCategoryCommandHandler(IWorkSampleCategoryRepository workSampleCategoryRepository) : IRequestHandler<DeleteWorkSampleCategoryCommand, bool>
{
	public async Task<bool> Handle(DeleteWorkSampleCategoryCommand request, CancellationToken cancellationToken)
	{
		var workSampleCategory = await workSampleCategoryRepository.GetBy(request.Id);

		if (workSampleCategory is null)
			return false;


		await workSampleCategoryRepository.DeleteAsync(workSampleCategory);
		return true;
	}
}
