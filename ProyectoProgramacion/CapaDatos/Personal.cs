using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Personal
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DocumentoPersona CodigoDocumentoPersona { get; set; } //Codigo Documento Persona
        public string NumeroDocumento { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }
        public bool Vigencia { get; set; }
        public SistemaPensiones CodigoSistemaPensiones { get; set; } //Codigo Sistema Pensiones

        public string NombreCompleto
        {
            get
            {
                return this.ApellidoPaterno + " " + this.ApellidoMaterno
                    + " " + this.Nombre;
            }
        }

        public string Documento
        {
            get
            {
                return CodigoDocumentoPersona.Nombre;
            }
        }

        public string Sistema
        {
            get
            {
                return CodigoSistemaPensiones.Siglas;
            }
        }
    }
}
