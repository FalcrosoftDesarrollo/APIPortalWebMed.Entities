namespace APIPortalKiosco.Entities
{
    public class CineFansData
    {
        public string Correo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Documento { get; set; }
        public string Genero { get; set; }
        public string Barrio { get; set; }
        public string Municipio { get; set; }
        public string Celular { get; set; }
        public List<object> Movimientos { get; set; }
        public string NombreCompleto { get { return Nombre + " " + Apellido; } }
        public decimal PuntosVencidos { get; set; }
        public decimal PuntosRedimidos { get; set; }
        public decimal PuntosAcumulados { get; set; }
        public decimal PuntosDisponibles { get; set; }
        public string FechaCF { get; set; }
        public string FechaCL { get; set; }
        public string FechaCB { get; set; }
        public string FechaCBDD { get; set; }
        public string FechaCBMM { get; set; }
        public decimal Saldo { get; set; }
        public int Nivel { get; set; }
        public string ReclsfcDD { get; set; }
        public string ReclsfcMM { get; set; }
        public string ReclsfcYY { get; set; }
        public int Visitas { get; set; }
        public int VisitasTotal { get; set; }
        public string VisitasFalta { get; set; }
        public string NivelCF { get; set; }
        public string Acumulado { get; set; }
    }
}
