using Microsoft.AspNetCore.Http;
using ResumeAppApi.Application.Informations.Dtos;


namespace ResumeAppApi.Application.Informations.Commands.CreateInformation
{
	public class CreateInformationCommand : IRequest<InformationDto>
	{
		public string FirstName { get; set; } = default!;
		public string LastName { get; set; } = default!;
		public string About { get; set; } = default!;
		public string Address { get; set; } = default!;
		public string PictureAlt { get; set; } = default!;
		public string Birthday { get; set; } = default!;
		public string Languages { get; set; } = default!;
		public string Nationality { get; set; } = default!;
		public string ShortAbout { get; set; } = default!;
	}
}
