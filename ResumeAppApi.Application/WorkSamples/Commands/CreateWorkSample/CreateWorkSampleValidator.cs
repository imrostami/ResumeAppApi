namespace ResumeAppApi.Application.WorkSamples.Commands.CreateWorkSample;

public class CreateWorkSampleValidator : AbstractValidator<CreateWorkSampleCommand>
{
    public CreateWorkSampleValidator()
    {
        RuleFor(x=>x.Name).NotEmpty()
            .WithMessage("نام وارد نشده");

        RuleFor(x => x.Description).NotEmpty()
            .WithMessage("توضیحات وارد نشده");

        

    }
}
