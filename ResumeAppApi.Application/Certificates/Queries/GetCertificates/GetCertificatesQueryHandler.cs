using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using ResumeAppApi.Application.Certificates.Dtos;

namespace ResumeAppApi.Application.Certificates.Queries.GetCertificates;

public class GetCertificatesQueryHandler(ICertificateRepository certificateRepository,
	IMapper mapper) : IRequestHandler<GetCertificatesQuery, IEnumerable<CertificateDto>>
{
	public async Task<IEnumerable<CertificateDto>> Handle(GetCertificatesQuery request, CancellationToken cancellationToken)
		=> await certificateRepository.Query()
		.OrderByDescending(c => c.CreationTime)
		.ProjectTo<CertificateDto>(mapper.ConfigurationProvider)
		.ToListAsync();
}
