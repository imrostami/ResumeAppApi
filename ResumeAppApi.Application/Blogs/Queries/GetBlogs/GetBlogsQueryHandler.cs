using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using ResumeAppApi.Application.Blogs.Dtos;

namespace ResumeAppApi.Application.Blogs.Queries.GetBlogs;

public class GetBlogsQueryHandler(IBlogArticleRepository blogArticleRepository,
    IMapper mapper) : IRequestHandler<GetBlogsQuery, IEnumerable<BlogDto>>
{
    public async Task<IEnumerable<BlogDto>> Handle(GetBlogsQuery request, CancellationToken cancellationToken)
    {
        return await blogArticleRepository.Query()
            .OrderByDescending(x => x.CreationTime)
            .ProjectTo<BlogDto>(mapper.ConfigurationProvider)
            .ToListAsync(cancellationToken);

    }
}
