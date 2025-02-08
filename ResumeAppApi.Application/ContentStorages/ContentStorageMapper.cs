using ResumeAppApi.Application.ContentStorages.Commands.CreateStorage;
using ResumeAppApi.Application.ContentStorages.Commands.UpdateStorage;
using ResumeAppApi.Application.ContentStorages.Dtos;
using ResumeAppApi.Domain.Entities.ContentStorageAgg;

namespace ResumeAppApi.Application.ContentStorages;

public class ContentStorageMapper : Profile
{
	public ContentStorageMapper()
	{
		CreateMap<ContentStorage, ContentStorageDto>()
			.ReverseMap();
		CreateMap<ContentStorage, CreateStorageCommand>()
			.ReverseMap();

		CreateMap<UpdateStorageCommand, ContentStorage>()
			.ReverseMap();

		CreateMap<UpdateStorageCommand, ContentStorageDto>()
			.ReverseMap();
		
	}
}
