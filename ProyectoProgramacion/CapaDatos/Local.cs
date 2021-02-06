

namespace CapaDatos
{
    public class Local
    {
        public int Codigo { get; set; }
        public Empresa Empresa { get; set; } //Codigo Empresa
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public bool Vigencia { get; set; }

        public string CodigoLocal
        {
            get
            {
                return this.Codigo + " ";
            }
        }
        public string CodigoEmpresa
        {
            get
            {
                return this.Empresa.Codigo + " ";
            }
        }

        public string NombreEmpresa
        {
            get
            {
                return this.Empresa.RazonSocial;
            }
        }
    }
}
