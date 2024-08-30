namespace ResumeAppApi.Application.WorkSamples.Commands.DeleteWorkSample;

public class DeleteWorkSampleCommand : IRequest<bool>
{
    public int Id { get; set; }
}
