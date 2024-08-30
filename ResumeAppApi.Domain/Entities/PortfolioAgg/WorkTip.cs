namespace ResumeAppApi.Domain.Entities.PortfolioAgg;

public class WorkTip
{
    public int TipId { get; set; }
    public string Title { get; set; } = default!;
    public string Caption { get; set; } = default!;
    public string Icon { get; set; } = default!;
}