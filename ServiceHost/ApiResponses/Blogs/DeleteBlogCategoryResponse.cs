﻿using ServiceHost.Responses;

namespace ServiceHost.ApiResponses.Blogs
{
	public class DeleteBlogCategoryResponse(bool ok) : IResponse

	{
		public bool Ok => ok;

		public string Message => ok ? ResponseMessage.Deleted() :
			ResponseMessage.NotFound();
	}
}
