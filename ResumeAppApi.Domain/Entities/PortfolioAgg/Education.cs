namespace ResumeAppApi.Domain.Entities.PortfolioAgg;

public class Education
{
    public int Id { get; set; }
    public string University { get; set; } = default!;
    public string Title { get; set; } = default!;
    public string Description { get; set; } = default!;
    public DateTime StartDate { get; set; } = default!;
    public DateTime EndDate { get; set; } = default!;
}
