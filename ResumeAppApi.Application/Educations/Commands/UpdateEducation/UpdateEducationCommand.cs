namespace ResumeAppApi.Application.Educations.Commands.UpdateEducation
{
	public class UpdateEducationCommand : IRequest<bool>
	{
        public int Id { get; set; }
        public string University { get; set; } = default!;
		public string Title { get; set; } = default!;
		public string Description { get; set; } = default!;
		public string StartDate { get; set; } = default!;
		public string EndDate { get; set; } = default!;
	}
}
