﻿using AutoMapper;
using UrnaEletronica.Application.DTOs;
using UrnaEletronica.Domain.Model;

namespace UrnaEletronica.Application.Mappers
{
    public class PartyProfile : Profile
    {
        public PartyProfile()
        {
            CreateMap<Party, PartyDto>().ReverseMap();
        }
    }
}
