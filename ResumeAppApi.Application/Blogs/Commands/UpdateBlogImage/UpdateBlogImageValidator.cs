namespace ResumeAppApi.Application.Blogs.Commands.UpdateBlogImage
{
	public class UpdateBlogImageValidator : AbstractValidator<UpdateBlogImageCommand>
	{
        public UpdateBlogImageValidator()
        {
			RuleFor(x => x.Picture)
		   .NotEmpty()
		   .WithMessage("عکس نباید خالی باشد");

			RuleFor(x => x.PircutrAlt)
				.NotEmpty()
				.WithMessage("alt عکس الزامی است");
		}
    }
}
