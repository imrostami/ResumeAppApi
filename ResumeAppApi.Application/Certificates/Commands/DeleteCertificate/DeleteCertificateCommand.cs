namespace ResumeAppApi.Application.Certificates.Commands.DeleteCertificate;

public class DeleteCertificateCommand : IRequest<bool>
{
    public int Id { get; set; }
}
