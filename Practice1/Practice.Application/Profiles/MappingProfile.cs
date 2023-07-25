using AutoMapper;
using Practice.Application.Features.Cinema.DTOs;
using Practice.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Practice.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<CinemaEntity, CreateCinemaDto>().ReverseMap();

        }
    }
}
