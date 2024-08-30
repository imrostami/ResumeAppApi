namespace ResumeAppApi.Application.Skills.Commands.CreateSkill;

public class CreateSkillValidator : AbstractValidator<CreateSkillCommand>
{
    public CreateSkillValidator()
    {
        RuleFor(x => x.SkillName).NotEmpty()
               .WithMessage("نام نباید خالی باشد");

        RuleFor(x => x.SkillScore)
            .LessThan(101)
            .WithMessage("امتیاز نمی تواند بزرگتر از 100 باشد")
            .GreaterThan(-1)
            .WithMessage("عدد نمی تواند کوچکتر از 0 باشد");
    }
}
