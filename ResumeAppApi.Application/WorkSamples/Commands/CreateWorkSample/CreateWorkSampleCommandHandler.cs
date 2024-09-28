

namespace ResumeAppApi.Application.WorkSamples.Commands.CreateWorkSample;

public class CreateWorkSampleCommandHandler(IWorkSampleRepository workSampleRepository,
	IWorkSampleCategoryRepository workSampleCategoryRepository,IMapper mapper,
	IFileUploader fileUploader) : IRequestHandler<CreateWorkSampleCommand, WorkSampleDto>
{
	public async Task<WorkSampleDto?> Handle(CreateWorkSampleCommand request, CancellationToken cancellationToken)
	{
		var category = await workSampleCategoryRepository.GetBy(request.CategoryId);

		if (category is null)
			return null;


		var workSampleImageUploadResult = await fileUploader.UploadDefault(request.Picture, AppDirectories.Images, "WorkSamples");
		var mappedWorkSample = mapper.Map<WorkSample>(request);
		mappedWorkSample.Picture = workSampleImageUploadResult;

		var createWorkSampleResult = await workSampleRepository.CreateAsync(mappedWorkSample);



		return mapper.Map<WorkSampleDto>(createWorkSampleResult);

	}
}
