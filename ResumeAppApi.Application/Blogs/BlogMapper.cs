using MD.PersianDateTime.Standard;
using ResumeAppApi.Application.Blogs.Commands.CreateBlog;
using ResumeAppApi.Application.Blogs.Commands.UpdateBlog;
using ResumeAppApi.Application.Blogs.Dtos;
using ResumeAppApi.Domain.Entities.BlogAgg;

namespace ResumeAppApi.Application.Blogs;

public class BlogMapper : Profile
{
    public BlogMapper()
    {
        CreateMap<BlogArticle, BlogDto>()

            .ForMember(x => x.CategoryName, obj =>
            obj.MapFrom(map => map.BlogArticleCategory.CategoryName))

            .ForMember(x => x.Id, obj => obj
            .MapFrom(map => map.ArticleId))


            .ForMember(x => x.CreationTime, obj =>
            obj.MapFrom(x => new PersianDateTime(x.CreationTime).ToShortDateString()))

            .ForMember(x => x.CreationTimeLongDate, obj =>
            obj.MapFrom(x => new PersianDateTime(x.CreationTime).ToLongDateString()))

            .ForMember(x => x.LastUpdateTime, obj =>
            obj.MapFrom(x => new PersianDateTime(x.LastUpdateTime).ToShortDateString()))

            .ForMember(x => x.LastUpdateTimeLongDate, obj =>
            obj.MapFrom(x => new PersianDateTime(x.LastUpdateTime).ToLongDateString()))
            
            .ReverseMap();


        CreateMap<CreateBlogCommand, BlogArticle>().ReverseMap();
        CreateMap<UpdateBlogCommand, BlogArticle>()
            .ReverseMap();

	}
}
