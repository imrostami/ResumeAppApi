using ResumeAppApi.Application.Certificates.Dtos;

namespace ResumeAppApi.Application.Certificates.Queries.GetCertificateById;

public class GetCertificateByIdQueryHandler(ICertificateRepository certificateRepository
	,IMapper mapper) : IRequestHandler<GetCertificateByIdQuery, CertificateDto>
{
	public async Task<CertificateDto?> Handle(GetCertificateByIdQuery request, CancellationToken cancellationToken)
	{
		var certificate = await certificateRepository.GetBy(request.Id);
		if (certificate is null)
			return null;

		return mapper.Map<CertificateDto>(certificate);
	}
}
