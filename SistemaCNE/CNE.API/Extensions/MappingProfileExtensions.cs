using AutoMapper;
using CNE.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CNE.Common.Models;

namespace CNE.API.Extensions
{
    public class MappingProfileExtensions : Profile
    {
        public MappingProfileExtensions()
        {
            CreateMap<DepartamentoViewModel, tbDepartamentos>().ReverseMap();
            CreateMap<PersonaViewModel, tbPersonas>().ReverseMap();
            CreateMap<PresidenteViewModel, tbPresidentes>().ReverseMap();
            CreateMap<VotoViewModel, tbVotos>().ReverseMap();
        }
    }
}
