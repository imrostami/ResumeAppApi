using ResumeAppApi.Application.Educations.Dtos;

namespace ResumeAppApi.Application.Educations.Commands.CreateEducation;

public class CreateEducationCommandHandler(IEducationRepository educationRepository,
	IMapper mapper) : IRequestHandler<CreateEducationCommand, EducationDto>
{
	public async Task<EducationDto> Handle(CreateEducationCommand request, CancellationToken cancellationToken)
	{
		var education = mapper.Map<Education>(request);
		var createdEducation = await educationRepository.CreateAsync(education);

		return mapper.Map<EducationDto>(createdEducation);
	}
}
