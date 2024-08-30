namespace ResumeAppApi.Domain.Entities.PortfolioAgg;

/// <summary>
///  راه های ارتباطی
/// </summary>
public class ContactInfo
{
    public int ContactId { get; set; }
    public string ContactName { get; set; } = default!;
    public string ContactValue { get; set; } = default!;

}