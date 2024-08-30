using ResumeAppApi.Application.BlogCategories.Commands.CreateBlogCategory;
using ResumeAppApi.Application.BlogCategories.Commands.UpdateBlogCategory;
using ResumeAppApi.Application.BlogCategories.Dtos;
using ResumeAppApi.Domain.Entities.BlogAgg;

namespace ResumeAppApi.Application.BlogCategories;

public class BlogCateogryMapper : Profile
{
    public BlogCateogryMapper()
    {
        CreateMap<BlogArticleCategory, BlogCategoryDto>()
            .ReverseMap();

        CreateMap<CreateBlogCategoryCommand, BlogArticleCategory>().ReverseMap();
        CreateMap<UpdateBlogCategoryCommand, BlogArticleCategory>().ReverseMap();
    }
}
