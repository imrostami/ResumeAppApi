namespace ResumeAppApi.Application.Messages.Dtos
{
	public class MessagePaggedDto
	{
		public long PageNumber { get; set; }
		public long PageSize { get; set; }
        public long TotalPages { get; set; }
		public long TotalRecords { get; set; }
        public IEnumerable<MessageDto> Messages { get; set; }
    }
}
