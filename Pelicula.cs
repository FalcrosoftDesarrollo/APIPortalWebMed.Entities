using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIPortalWebMed.Entities
{
    public class Pelicula
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Sinopsis { get; set; }
        public string TituloOriginal { get; set; }
        public string Imagen { get; set; }
        public string RutaCartelera { get; set; }
        public string Censura { get; set; }
        public string Idioma { get; set; }
        public string Genero { get; set; }
        public string Pais { get; set; }
        public string Duracion { get; set; }
        public string Medio { get; set; }
        public string Formato { get; set; }
        public string Version { get; set; }
        public string Trailer1 { get; set; }
        public string Trailer2 { get; set; }
        public string FechaEstreno { get; set; }
        public string Reparto { get; set; }
        public string Director { get; set; }
        public string Distribuidor { get; set; }
        public bool Habilitado { get; set; }
        public List<DateTime> DiasDisponibles { get; set; }
        public List<string> CinesDisponibles { get; set; }
    }

}
