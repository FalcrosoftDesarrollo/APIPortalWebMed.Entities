using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPortalKiosco.Entities
{
    public class MapaSala
    {
        public int Sala { get; set; }
        public int Teatro { get; set; }
        public int Funcion { get; set; }

        public string Correo { get; set; }
        public string Tercero { get; set; }
        public string FechaFuncion { get; set; }
    }
}
