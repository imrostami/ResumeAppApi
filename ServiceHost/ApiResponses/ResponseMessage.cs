
namespace ServiceHost.ApiResponses
{
	internal static class ResponseMessage
	{
		internal static string NotFound()
			=> "مورد درخواستی وجود ندارد";
		internal static string NotFound(int id)
			=> $"مورد درخواستی با شناسه {id} وجود ندارد";

		internal static string NotFound(string segment)
			=> $"{segment} درخواستی وجود ندارد";

		internal static string Duplicate()
			=> "امکان ثبت مورد تکراری وجود ندارد";

		internal static string Duplicate(string s)
			=> $"نمی توان مورد تکراری {s} را اضافه کرد";

		internal static string Added()
			=> "درخواست با موفقیت ثبت شد";
		internal static string Added(string segment)
			=> $"{segment} با موفقیت اضافه شد";

		internal static string Broken()
			=> "درخواست قابل پردازش نیست";

		internal static string Deleted()
			=> "مورد درخواستی حذف شد";

		internal static string Deleted(string segment)
			=> $"{segment} مورد نظر با موفقیت حذف شد";

		internal static string Deleted(int id)
			=> $"شناسه {id} با موفقیت حذف شد";

		internal static string Updated()
			=> "بروزرسانی موفقیت آمیز بود";

		internal static string Updated(string segment)
			=> $"{segment} بروزرسانی شد";


		internal static string Sucssesfuly()
			=> "عملیات با موفقیت انجام شد";

		internal static string Sucssesfuly(string segment)
			=> $"{segment} موفقیت آمیز بود";
	}
}
