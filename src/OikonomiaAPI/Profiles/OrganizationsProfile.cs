using AutoMapper;
using OikonomiaAPI.Dtos;
using OikonomiaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OikonomiaAPI.Profiles
{
    public class OrganizationsProfile : Profile
    {
        public OrganizationsProfile()
        {
            //Source -> Target
            CreateMap<Organization, OrganizationReadDto>();
            CreateMap<OrganizationCreateDto, Organization>();
            CreateMap<OrganizationUpdateDto, Organization>();
            CreateMap<Organization, OrganizationUpdateDto>();
        }
    }
}
