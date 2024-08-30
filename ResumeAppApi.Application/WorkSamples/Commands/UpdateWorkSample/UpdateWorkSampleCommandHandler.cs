
namespace ResumeAppApi.Application.WorkSamples.Commands.UpdateWorkSample;

public class UpdateWorkSampleCommandHandler(IWorkSampleRepository workSampleRepository,
	IMapper mapper) : IRequestHandler<UpdateWorkSampleCommand, bool>
{
	public async Task<bool> Handle(UpdateWorkSampleCommand request, CancellationToken cancellationToken)
	{
		var workSample = await workSampleRepository.GetBy(request.Id);

		if (workSample is null)
			return false;

		var mappedWorkSample = mapper.Map(request,workSample);
		await workSampleRepository.UpdateAsync(mappedWorkSample);

		return true;
	}
}
