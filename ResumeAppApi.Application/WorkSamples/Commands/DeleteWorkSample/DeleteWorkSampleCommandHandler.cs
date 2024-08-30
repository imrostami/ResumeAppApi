
namespace ResumeAppApi.Application.WorkSamples.Commands.DeleteWorkSample;

public class DeleteWorkSampleCommandHandler(IWorkSampleRepository workSampleRepository) : IRequestHandler<DeleteWorkSampleCommand, bool>
{
	public async Task<bool> Handle(DeleteWorkSampleCommand request, CancellationToken cancellationToken)
	{
		var workSample = await workSampleRepository.GetBy(request.Id);

		if (workSample is null)
			return false;


		await workSampleRepository.DeleteAsync(workSample);
		return true;


	}
}
