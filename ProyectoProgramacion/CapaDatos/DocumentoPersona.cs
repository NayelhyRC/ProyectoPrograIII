

namespace CapaDatos
{
    public class DocumentoPersona
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string CodigoSunat { get; set; }
        public string Tipo { get; set; }
        public int CantidadMaxima { get; set; }
        public int CantidadMinima { get; set; }
        public bool Vigencia { get; set; }
    }
}
