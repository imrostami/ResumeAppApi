namespace ResumeAppApi.Domain.Entities.PortfolioAgg;

public class Information
{
    public int InformationId { get; set; }
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string About { get; set; } = default!;
    public string Address { get; set; } = default!;
    public string? Picture { get; set; } = default!;
    public string PictureAlt { get; set; } = default!;
    public string Birthday { get; set; } = default!;
    public string Languages { get; set; } = default!;
	public string Nationality { get; set; }= default!;




}
