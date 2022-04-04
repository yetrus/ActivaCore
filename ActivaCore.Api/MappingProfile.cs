using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ActivaCore.Api.Models;
using ActivaCore.Domain;


namespace ActivaCore.Api
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Models.EntidadUpdate, Domain.Entidad>();

            CreateMap<Domain.Entidad, Models.EntidadUpdate>();
        }
    }
}
