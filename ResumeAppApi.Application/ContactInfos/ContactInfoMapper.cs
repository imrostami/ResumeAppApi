using AutoMapper;
using ResumeAppApi.Application.ContactInfos.Commands.CreateContactInfo;
using ResumeAppApi.Application.ContactInfos.Commands.UpdateContactInfo;
using ResumeAppApi.Application.ContactInfos.Dtos;
using ResumeAppApi.Domain.Entities.PortfolioAgg;

namespace ResumeAppApi.Application.ContactInfos
{
	public class ContactInfoMapper : Profile
	{
        public ContactInfoMapper()
        {
            CreateMap<ContactInfo, ContactInfoDto>();
            CreateMap<CreateContactInfoCommand, ContactInfo>();
            CreateMap<UpdateContactInfoCommand, ContactInfo>();
        }
    }
}
