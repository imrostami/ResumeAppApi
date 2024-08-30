using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeAppApi.Application.Blogs.Commands.DeleteBlog
{
	public class DeleteBlogCommand : IRequest<bool>
	{
        public int Id { get; set; }
    }
}
