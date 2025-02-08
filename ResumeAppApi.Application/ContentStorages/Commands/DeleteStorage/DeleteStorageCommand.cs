namespace ResumeAppApi.Application.ContentStorages.Commands.DeleteStorage
{
	public class DeleteStorageCommand : IRequest<bool>
	{
		public int Id { get; set; }
	}
}
