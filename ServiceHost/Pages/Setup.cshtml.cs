using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ResumeAppApi.Domain.Entities;
using ResumeAppApi.Domain.Repositories;
using ResumeAppApi.Infrustructre.Persistense;

namespace ServiceHost.Pages
{
	[BindProperties]
	public class SetupModel(AppDbContext dbContext, UserManager<User> userManager, IMediator mediator) : PageModel
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string About { get; set; }
		public string Address { get; set; }
		public string Birthday { get; set; }
		public string Languages { get; set; }
		public string Nationality { get; set; }
		public string ShortAbout { get; set; }
		public IFormFile ProfilePhoto { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }


		public IActionResult OnGet()
		{
			if (dbContext.Users.Any())
				return NotFound();

			return Page();
		}

		public async Task<IActionResult> OnPost()
		{
			if (dbContext.Users.Any())
				return NotFound();


			if (ModelState.IsValid)
			{
				var user = new User()
				{
					Email = Email,
					UserName = Email
				};

				await userManager.CreateAsync(user, Password);
				var informationCommand = new CreateInformationCommand()
				{
					About = About,
					Address = Address,
					Birthday = Birthday,
					FirstName = FirstName,
					LastName = LastName,
					Languages = Languages,
					Nationality = Nationality,
					ShortAbout = ShortAbout,
				};

				var changeProfilePicCommand = new ChangeInformationImageCommand()
				{
					Image = ProfilePhoto,
					PictureAlt = $"{FirstName} {LastName}"
				};

				var createInformationResult = await mediator.Send(informationCommand);
				var changePictureResult = await mediator.Send(changeProfilePicCommand);

				var response = new CreateInformationResponse(createInformationResult);
				return new JsonResult(response);
			}
			return Page();
		}
	}
}
