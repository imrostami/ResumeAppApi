﻿namespace ResumeAppApi.Application.Messages;

public class MessageDto
{
	public int MessageId { get; set; }
	public string Email { get; set; }
	public string Title { get; set; }
	public string FirstName { get; set; }
	public string LastName { get; set; }
	public string Body { get; set; }
	public string CreationTime { get; set; }
	public string ShortDateTime {  get; set; }
    public string LongDate { get; set; }
    public string? TopicId { get; set; }
    public bool Recived { get; set; }
    public IEnumerable<MessageReplyDto> Replies { get; set; }



}
