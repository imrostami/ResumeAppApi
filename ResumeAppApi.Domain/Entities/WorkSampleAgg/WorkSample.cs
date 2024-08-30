namespace ResumeAppApi.Domain.Entities.WorkSampleAgg;

public class WorkSample
{
    public int SampleId { get; set; }

    public WorkSampleCategory WorkSampleCategory { get; set; }
    public int CategoryId { get; set; }

    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public string Picture { get; set; } = default!;
    public string PictureAlt { get; set; } = default!;



}
