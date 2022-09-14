using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using TiendaServicios.Api.Autor.Modelo;
using TiendaServicios.Api.Autor.Persistencia;

namespace TiendaServicios.Api.Autor.Aplicacion
{
    public class Consulta
    {
        //mapear clientes y devolver datos en lista
        //cambiamos AutorLibro por AutorDto
        public class ListaAutor : IRequest<List<AutorDto>>{
            
        
        
        }

        //recibir lista autor y devolver la lista
        //cambiamos AutorLibro por AutorDto
        public class Manejador : IRequestHandler<ListaAutor, List<AutorDto>>
        {

            //instanciar de persistencia clases contexto autor
            public readonly ContextoAutor _contexto;

            //aumentar mapper instanciar mapper
            public readonly IMapper _mapper;

            public Manejador(ContextoAutor contexto, IMapper mapper)
            {
                _contexto = contexto;
                _mapper = mapper;
            }


            //public async Task<List<AutorLibro>> Handle(ListaAutor request, CancellationToken cancellationToken)
            //{
            //    var autores = await _contexto.AutorLibro.ToListAsync();

            //    return autores;

            //    //throw new NotImplementedException();
            //}

            public async Task<List<AutorDto>> Handle(ListaAutor request, CancellationToken cancellationToken)
            {
                var autores = await _contexto.AutorLibro.ToListAsync();

                var autoresDto = _mapper.Map<List<AutorLibro>, List<AutorDto>>(autores);

                return autoresDto;

            }
        }
    }
}
