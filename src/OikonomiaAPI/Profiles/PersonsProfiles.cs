using AutoMapper;
using OikonomiaAPI.Dtos;
using OikonomiaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OikonomiaAPI.Profiles
{
    public class PersonsProfile : Profile
    {

        public PersonsProfile()
        {
            //Source -> Target
            CreateMap<Person, PersonReadDto>();
            CreateMap<PersonCreateDto, Person>();
            CreateMap<PersonUpdateDto, Person>();
            CreateMap<Person, PersonUpdateDto>();
        }
    }
}
