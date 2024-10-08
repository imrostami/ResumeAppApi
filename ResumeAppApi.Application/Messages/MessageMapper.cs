﻿using AutoMapper;
using MD.PersianDateTime.Standard;
using ResumeAppApi.Application.Messages.Commands.CreateMessage;
using ResumeAppApi.Application.Messages.Commands.CreateMessageReply;
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
				obj.MapFrom(map => map.IsRecived))

				.ForMember(x => x.FirstName, obj =>
				obj.MapFrom(map => map.SenderFirstName))

				.ForMember(x => x.LastName, obj =>
				obj.MapFrom(map => map.SenderLastName))

				.ForMember(x => x.Replies, obj =>
				obj.MapFrom(x => x.MessageReplies));



		CreateMap<CreateMessageCommand, Message>();
		CreateMap<Message, UnReadMessageDto>();


		CreateMap<MessageReply, MessageReplyDto>()
			.ForMember(x => x.Text, obj =>
			obj.MapFrom(map => map.ReplyBody))

			.ForMember(x => x.CreationTime, src => src.
				MapFrom(map => new PersianDateTime(map.ReplyDate)
				.ToShortDateString()))


			   .ForMember(x => x.ShortDateTime, obj =>
				obj.MapFrom(map => new PersianDateTime(map.ReplyDate)
				.ToShortDateTimeString()))


				.ForMember(x => x.LongDate, obj =>
				obj.MapFrom(map => new PersianDateTime(map.ReplyDate).
				ToLongDateString()))

			.ForMember(x => x.TopicId, obj =>
			obj.MapFrom(map => map.Message.TopicId))
			.ReverseMap();




		CreateMap<CreateMessageReplyCommand, MessageReply>()

			.ForMember(x => x.ReplyBody, obj =>
			obj.MapFrom(map => map.Text));
	}
}
