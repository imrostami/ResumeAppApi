using Microsoft.AspNetCore.Http;

namespace ResumeAppApi.Application.Informations.Commands.UpdateInformation
{
	public class UpdateInformationCommand : IRequest<bool>
	{
        public int Id { get; set; }
        public string FirstName { get; set; } = default!;
		public string LastName { get; set; } = default!;
		public string About { get; set; } = default!;
		public string ShortAbout { get; set; } = default!;
		public string Address { get; set; } = default!;
		public string Birthday { get; set; } = default!;
		public string Languages { get; set; } = default!;
		public string Nationality { get; set; } = default!;
	}
}
