using System;

namespace CapaDatos
{
    public class CuentaBancaria
    {

        public int Codigo { get; set; }
        public Empresa CodigoEmpresa { get; set; }
        public EntidadBancaria CodigoEntidadBancaria { get; set; }
        public string CCI { get; set; }
        public string NumeroCuenta { get; set; }
        public Char TipoMoneda { get; set; }
        public string NombreP { get; set; }
        public bool Vigencia { get; set; }

    }
}
