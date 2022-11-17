using AutoMapper;
using BlogN.Models;
using BlogN.Models.Dto;

namespace BlogN.API.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Article, ArticleDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
