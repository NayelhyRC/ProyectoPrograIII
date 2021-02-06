using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public Personal CodigoPersonal { get; set; } //Codigo Personal
        public Perfil CodigoPerfil { get; set; } //Codigo Perfil
        public string Nombre { get; set; }
        public string Clave { get; set; }
        public string Tipo { get; set; }
        public bool Vigencia { get; set; }
        public Local CodigoLocal { get; set; } //Codigo Local

        public string NombrePersonal
        {
            get
            {
                return this.CodigoPersonal.NombreCompleto;
            }
        }
        public string LocalPersonal
        {
            get
            {
                return this.CodigoLocal.Nombre;
            }
        }
        public string Perfil
        {
            get
            {
                return this.CodigoPerfil.Nombre;
            }
        }
    }
}
