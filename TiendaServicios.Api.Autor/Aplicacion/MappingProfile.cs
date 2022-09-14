using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaServicios.Api.Autor.Modelo;

namespace TiendaServicios.Api.Autor.Aplicacion
{
    public class MappingProfile : Profile
    {

        //mapeo entre modelo y dto
        public MappingProfile()
        {
            CreateMap<AutorLibro, AutorDto>();
        }

    }
}
