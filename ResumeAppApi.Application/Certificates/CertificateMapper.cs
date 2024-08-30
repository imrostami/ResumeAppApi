using MD.PersianDateTime.Standard;
using ResumeAppApi.Application.Certificates.Commands.CreateCertificate;
using ResumeAppApi.Application.Certificates.Commands.UpdateCertificate;
using ResumeAppApi.Application.Certificates.Dtos;

namespace ResumeAppApi.Application.Certificates;

public class CertificateMapper : Profile
{
    public CertificateMapper()
    {
		CreateMap<Certificate, CertificateDto>()

			.ForMember(x => x.CreationTime, src => src.
				MapFrom(map => new PersianDateTime(map.CreationTime)
				.ToShortDateString()))

			.ForMember(x => x.ShortDateTime, obj =>
				obj.MapFrom(map => new PersianDateTime(map.CreationTime)
				.ToShortDateTimeString()))


				.ForMember(x => x.LongDate, obj =>
				obj.MapFrom(map => new PersianDateTime(map.CreationTime).
				ToLongDateString()));



		CreateMap<CreateCertificateCommand,Certificate>();
		CreateMap<UpdateCertificateCommand,Certificate>();
	}
}
