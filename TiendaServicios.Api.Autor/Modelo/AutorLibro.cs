using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TiendaServicios.Api.Autor.Modelo
{
    public class AutorLibro
    {
        public int AutorLibroId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        //de uno a muchos
        public ICollection<GradoAcademico> ListaGradoAcademico { get; set; }
        
        //valor universal
        public string AutorLibroGuid { get; set; }

    }
}
