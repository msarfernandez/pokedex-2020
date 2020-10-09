using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pokemon

    {
        // esto es un comentario nuevo...
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public string UrlImage { get; set; }

        public Tipo Tipo { get; set; }

    }
}
