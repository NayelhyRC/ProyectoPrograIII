namespace CapaDatos
{
    public class LocalPersonal
    {
        public int Codigo { get; set; }
        public Personal Personal { get; set; }
        public Local Local { get; set; }
        public string Cargo { get; set; }
        public float Sueldo { get; set; }
        public string CorreoEmpresarial { get; set; }
        public string CelularEmpresarial { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
        public bool Vigencia { get; set; }

        public string NombreLocal
        {
            get
            {
                return (this.Local != null ? this.Local.Nombre : "");
            }
        }

        public string NombrePersonal
        {
            get
            {
                return (this.Personal != null ? this.Personal.NombreCompleto : "");
            }
        }

        public string DocumentoPersonal
        {
            get
            {
                return (this.Personal != null ? this.Personal.NumeroDocumento : "");
            }
        }
    }
}
