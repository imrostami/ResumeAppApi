using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace ResumeAppApi.Application.ContactInfos.Queries.GetAllContacts;

public class GetAllContactQueryHandler(IContactInfoRepository contactInfoRepository,
	IMapper mapper) : IRequestHandler<GetAllContactQuery, IEnumerable<ContactInfoDto>>
{
	public async Task<IEnumerable<ContactInfoDto>> Handle(GetAllContactQuery request, CancellationToken cancellationToken)
		=> await contactInfoRepository.Query()
		.ProjectTo<ContactInfoDto>(mapper.ConfigurationProvider)
		.ToListAsync();
}
