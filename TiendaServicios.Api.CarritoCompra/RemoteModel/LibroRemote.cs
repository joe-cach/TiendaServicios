using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaServicios.Api.CarritoCompra.RemoteModel
{
    public class LibroRemote
    {
        [Key]
        public Guid? LibreriaMateriaId { get; set; }
        public string Titulo { get; set; }

        public DateTime? FechaPublicacion { get; set; }

        //para conectar entre microservicios
        public Guid AutorLibro { get; set; }
    }
}
