using ResumeAppApi.Application.WorkTips.Dtos;

namespace ResumeAppApi.Application.WorkTips.Queries.GetWorkTipById;

public class GetWorkTipByIdQuery : IRequest<WorkTipDto>
{
    public int Id { get; set; }
}
