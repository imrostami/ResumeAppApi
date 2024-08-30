using ResumeAppApi.Application.WorkSamples.Dtos;

namespace ResumeAppApi.Application.WorkSamples.Queries.GetWorkSampleById;

public class GetWorkSampleByIdQuery : IRequest<WorkSampleDto>
{
    public int Id { get; set; }
}
