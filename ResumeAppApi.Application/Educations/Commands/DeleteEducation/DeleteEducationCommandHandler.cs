
namespace ResumeAppApi.Application.Educations.Commands.DeleteEducation;

public class DeleteEducationCommandHandler(IEducationRepository educationRepository) : IRequestHandler<DeleteEducationCommand, bool>
{
	public async Task<bool> Handle(DeleteEducationCommand request, CancellationToken cancellationToken)
	{
		var education = await educationRepository.GetBy(request.Id);

		if (education is null)
			return false;

		await educationRepository.DeleteAsync(education);
		return true;
	}
}
