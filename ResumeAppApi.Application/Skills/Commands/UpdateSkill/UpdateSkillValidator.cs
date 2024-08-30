namespace ResumeAppApi.Application.Skills.Commands.UpdateSkill;

public class UpdateSkillValidator : AbstractValidator<UpdateSkillCommand>
{
    public UpdateSkillValidator()
    {
		RuleFor(x => x.SkillScore)
		   .LessThan(101)
		   .WithMessage("امتیاز نمی تواند بزرگتر از 100 باشد")
		   .GreaterThan(-1)
		   .WithMessage("عدد نمی تواند کوچکتر از 0 باشد");
	}
}
