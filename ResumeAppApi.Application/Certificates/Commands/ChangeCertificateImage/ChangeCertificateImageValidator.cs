﻿
namespace ResumeAppApi.Application.Certificates.Commands.ChangeCertificateImage;

public class ChangeCertificateImageValidator : AbstractValidator<ChangeCertificateImageCommand>
{
    public ChangeCertificateImageValidator()
    {
        RuleFor(x => x.Image)
            .NotEmpty()
            .WithMessage("عکس نباید خالی باشد");
    }
}