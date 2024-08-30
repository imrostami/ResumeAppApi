
namespace ResumeAppApi.Application.Educations.Commands.UpdateEducation;

public class UpdateEducationCommandHandler(IEducationRepository educationRepository,
	IMapper mapper) : IRequestHandler<UpdateEducationCommand, bool>
{
	public async Task<bool> Handle(UpdateEducationCommand request, CancellationToken cancellationToken)
	{
		var education = await educationRepository.GetBy(request.Id);

		if (education is null)
			return false;

		var mappedEducation =  mapper.Map(request, education);
		await educationRepository.UpdateAsync(mappedEducation);

		return true;
	}
}
