using AutoMapper;
using MVC_Tutorial.Models;

namespace Web_API;

public class MyMapper : Profile
{
    public MyMapper()
    {
        CreateMap<Category, CategoryDTO>().ReverseMap();
    }
}
