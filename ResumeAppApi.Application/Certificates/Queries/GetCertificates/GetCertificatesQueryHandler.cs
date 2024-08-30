using ResumeAppApi.Application.Certificates.Dtos;

namespace ResumeAppApi.Application.Certificates.Queries.GetCertificates;

public class GetCertificatesQueryHandler(ICertificateRepository certificateRepository,
	IMapper mapper) : IRequestHandler<GetCertificatesQuery, IEnumerable<CertificateDto>>
{
	public async Task<IEnumerable<CertificateDto>> Handle(GetCertificatesQuery request, CancellationToken cancellationToken)
	{
		var certificates = await certificateRepository.GetAll();
		return mapper.Map<IEnumerable<CertificateDto>>(certificates);
	}
}
