using ResumeAppApi.Application.WorkSamples.Dtos;

namespace ResumeAppApi.Application.WorkSamples.Queries.GetWorkSampleByCategoryId;

public class GetWorkSampleByCategoryIdQuery : IRequest<IEnumerable<WorkSampleDto>>
{
    public int CategoryId { get; set; }
}
