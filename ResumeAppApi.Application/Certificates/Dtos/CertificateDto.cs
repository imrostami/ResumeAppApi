namespace ResumeAppApi.Application.Certificates.Dtos;

public class CertificateDto
{
    public int CertificateId { get; set; }
    public string Name { get; set; }
	public string Caption { get; set; }
	public string Issuer { get; set; }
	public string Image { get; set; }
	public string ImageAlt { get; set; }
	public string CreationTime { get; set; }
    public string ShortDateTime { get; set; }
    public string LongDate { get; set; }
}
