
using Application.DTOs;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<AutorDTO, Autor>().ReverseMap();
            CreateMap<AutorRegisterDTO, Autor>().ReverseMap();
            CreateMap<GeneroDTO, Genero>().ReverseMap();
            CreateMap<GeneroRegisterDTO, Genero>().ReverseMap();
            CreateMap<LivroDTO, Livro>().ReverseMap();
            CreateMap<LivroRegisterDTO, Livro>().ReverseMap();
            CreateMap<LivroRequestDTO, Livro>().ReverseMap();

        }
    }
}
