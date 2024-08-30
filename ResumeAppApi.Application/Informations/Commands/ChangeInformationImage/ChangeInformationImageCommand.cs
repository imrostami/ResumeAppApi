using Microsoft.AspNetCore.Http;

namespace ResumeAppApi.Application.Informations.Commands.ChangeInformationImage
{
	public class ChangeInformationImageCommand : IRequest<bool>
	{
       
        public IFormFile Image { get; set; }
		public string PictureAlt { get; set; }
	}
}
