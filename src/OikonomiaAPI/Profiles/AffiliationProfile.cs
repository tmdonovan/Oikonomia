using AutoMapper;
using OikonomiaAPI.Dtos;
using OikonomiaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OikonomiaAPI.Profiles
{
    public class AffiliationsProfile : Profile
    {
        public AffiliationsProfile()
        {
            //Source -> Target
            CreateMap<Affiliation, AffiliationReadDto>();
            CreateMap<AffiliationCreateDto, Affiliation>();
            CreateMap<AffiliationUpdateDto, Affiliation>();
            CreateMap<Affiliation, AffiliationUpdateDto>();
        }
    }
}