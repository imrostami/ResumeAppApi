using ResumeAppApi.Application.Certificates.Dtos;

namespace ResumeAppApi.Application.Certificates.Queries.GetCertificateById;

public class GetCertificateByIdQuery : IRequest<CertificateDto>
{
	public GetCertificateByIdQuery(int id)
	{
		Id = id;
	}

	public int Id { get; set; }
}
