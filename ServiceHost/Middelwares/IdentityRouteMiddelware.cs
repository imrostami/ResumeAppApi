using Microsoft.EntityFrameworkCore;
using ResumeAppApi.Domain.Repositories;
using ResumeAppApi.Infrustructre.Persistense;

namespace ServiceHost.Middelwares
{
	public class IdentityRouteMiddelware(RequestDelegate next)
	{
		public async Task InvokeAsync(HttpContext context)
		{
			var route = context.Request.Path;

			if (route.StartsWithSegments("/api/Users/register"))
			{
				var dbContext = context.RequestServices.GetRequiredService<AppDbContext>();

				var userCount = await dbContext.Users.CountAsync();

				if (userCount>=1)
				{
					context.Response.StatusCode = StatusCodes.Status404NotFound;
					return;
				}

			}
			else if (route.StartsWithSegments("/api/Users/confirmEmail"))
			{
				context.Response.StatusCode = StatusCodes.Status404NotFound;
				return;
			}
			else if (route.StartsWithSegments("/api/Users/resendConfirmationEmail"))
			{
				context.Response.StatusCode = StatusCodes.Status404NotFound;
				return;
			}
			else if (route.StartsWithSegments("/api/Users/forgotPassword"))
			{
				context.Response.StatusCode = StatusCodes.Status404NotFound;
				return;
			}
			else if (route.StartsWithSegments("/api/Users/resetPassword"))
			{
				context.Response.StatusCode = StatusCodes.Status404NotFound;
				return;
			}
			else if (route.StartsWithSegments("/api/Users/manage/2fa"))
			{
				context.Response.StatusCode = StatusCodes.Status404NotFound;
				return;
			}
			else if (route.StartsWithSegments("/api/Users/manage/info"))
			{
				context.Response.StatusCode = StatusCodes.Status404NotFound;
				return;
			}



			await next(context);
		}
	}
}
