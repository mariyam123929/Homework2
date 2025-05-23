﻿using WebApiHomeTask1.DTO.Requests.Author;

namespace WebApiHomeTask1.Data.Mapping;

using AutoMapper;
using Homework2.Data.Models;
using WebApiHomeTask1.Data.Models;
using WebApiHomeTask1.DTO.Requests;
using static System.Runtime.InteropServices.JavaScript.JSType;







public class AuthorProfile : Profile
{
    public AuthorProfile()
    {
        CreateMap<AuthorAddRequest, Author>()
            .ForMember(dest => dest.AuthorName, opt =>
                opt.MapFrom(src => src.AuthorName))
            .ForMember(dest => dest.AuthorBooks, opt =>
                opt.MapFrom(src => src.AuthorBooks))
            .AfterMap((src, dest) =>
            {
                foreach (var book in dest.AuthorBooks)
                {
                    book.Author = dest;
                }

            });







    }
}
