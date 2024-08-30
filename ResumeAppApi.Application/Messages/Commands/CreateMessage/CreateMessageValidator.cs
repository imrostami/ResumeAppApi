namespace ResumeAppApi.Application.Messages.Commands.CreateMessage;

public class CreateMessageValidator : AbstractValidator<CreateMessageCommand>
{
	public CreateMessageValidator()
	{
		RuleFor(x => x.Email)
			.NotEmpty()
			.WithMessage("ایمیل نمیتواند خالی باشد")
			.EmailAddress()
			.WithMessage("لطفا یک آدرس ایمیل معتبر وارد کنید");


		RuleFor(x => x.Title)
			.NotEmpty()
			.WithMessage("عنوان پیام نمی تواند خالی باشد")
			.MaximumLength(100)
			.WithMessage("حداکثر طول عنوان 100 کاراکتر است");


		RuleFor(x => x.SenderLastName)
			.NotEmpty()
			.WithMessage("نام خانوادگی نمی تواند خالی باشد")
			.MaximumLength(120)
			.WithMessage("حداکثر طول نام خانوادگی 120 می باشد");


		RuleFor(x => x.SenderFirstName)
			.NotEmpty()
			.WithMessage("نام نمی تواند خالی باشد")
			.MaximumLength(50)
			.WithMessage("حداکثر طول نام 50 می باشد");

		RuleFor(x => x.Body)
			.NotEmpty()
			.WithMessage("متن پیام نمی تواند خالی باشد")
			.MaximumLength(1200)
			.WithMessage("حداکثر طول پیام 1200 می باشد");
	}
}
