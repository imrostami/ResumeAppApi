namespace ResumeAppApi.Application.WorkTips.Commands.DeleteWorkTip
{
	public class DeleteWorkTipCommand : IRequest<bool>
	{
        public int Id { get; set; }
    }
}
