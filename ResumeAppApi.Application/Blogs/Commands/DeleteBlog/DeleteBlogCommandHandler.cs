using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeAppApi.Application.Blogs.Commands.DeleteBlog
{
	internal class DeleteBlogCommandHandler(IBlogArticleRepository blogArticleRepository) : IRequestHandler<DeleteBlogCommand, bool>
	{
		public async Task<bool> Handle(DeleteBlogCommand request, CancellationToken cancellationToken)
		{
			var article = await blogArticleRepository.GetBy(request.Id);

			if(article is null)
				return false;

			await blogArticleRepository.DeleteAsync(article);
			return true;
		}
	}
}
