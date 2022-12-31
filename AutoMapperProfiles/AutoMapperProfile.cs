using AutoMapper;
using BeautyNails.DTOs;
using BeautyNails.Models;

namespace BeautyNails.AutoMapperProfiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();
            CreateMap<About, AboutDto>();
            CreateMap<AboutDto, About>();
            CreateMap<DaysOpen, DaysOpenDto>();
            CreateMap<DaysOpenDto, DaysOpen>();
            CreateMap<Review, ReviewDto>();
            CreateMap<ReviewDto, Review>();
        }
    }
}
