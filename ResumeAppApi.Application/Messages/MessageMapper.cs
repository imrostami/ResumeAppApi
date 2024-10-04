using AutoMapper;
using MD.PersianDateTime.Standard;
using ResumeAppApi.Application.Messages.Commands.CreateMessage;
using ResumeAppApi.Application.Messages.Dtos;
using ResumeAppApi.Domain.Entities.MessageAgg;

namespace ResumeAppApi.Application.Messages;

public class MessageMapper : Profile
{
	public MessageMapper()
	{
		CreateMap<Message, MessageDto>()

			   .ForMember(x => x.CreationTime, src => src.
				MapFrom(map => new PersianDateTime(map.CreationTime)
				.ToShortDateString()))


			   .ForMember(x => x.ShortDateTime, obj =>
				obj.MapFrom(map => new PersianDateTime(map.CreationTime)
				.ToShortDateTimeString()))


				.ForMember(x => x.LongDate, obj =>
				obj.MapFrom(map => new PersianDateTime(map.CreationTime).
				ToLongDateString()))


				.ForMember(x => x.Recived, obj =>
				obj.MapFrom(map => map.IsRecived));



		CreateMap<CreateMessageCommand, Message>();
		CreateMap<Message, UnReadMessageDto>();
	}
}
