using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeAppApi.Application.WorkTips.Commands.ChangeWorkTipIcon
{
	public class ChangeWorkTipIconValidator : AbstractValidator<ChangeWorkTipIconCommand>
	{
        public ChangeWorkTipIconValidator()
        {
            RuleFor(x => x.Icon)
                .NotNull()
                .WithMessage("آیکون نمیتواند خالی باشد");
        }
    }
}
