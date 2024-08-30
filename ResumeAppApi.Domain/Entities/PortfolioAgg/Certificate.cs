using System.Runtime.InteropServices;

namespace ResumeAppApi.Domain.Entities.PortfolioAgg;

public class Certificate
{
    public int CertificateId { get; set; }
    public string Name { get; set; } = default!;
    public string Caption { get; set; } = default!;
    public string Issuer { get; set; } = default!;
    public string Image { get; set; } = default!;
    public string ImageAlt { get; set; } = default!;
    public DateTime CreationTime { get; set; } = DateTime.Now;

}
