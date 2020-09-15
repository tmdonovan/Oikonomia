using AutoMapper;
using OikonomiaAPI.Dtos;
using OikonomiaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OikonomiaAPI.Profiles
{
    public class CodevaluesProfile : Profile
    {
        public CodevaluesProfile()
        {
            CreateMap<Codevalues, CodevaluesReadDto>();
        }
    }
}
