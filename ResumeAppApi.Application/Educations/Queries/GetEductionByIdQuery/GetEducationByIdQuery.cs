using ResumeAppApi.Application.Educations.Dtos;

namespace ResumeAppApi.Application.Educations.Queries.GetEductionByIdQuery
{
	public class GetEducationByIdQuery : IRequest<EducationDto>
	{
        public int Id { get; set; }
    }
}
