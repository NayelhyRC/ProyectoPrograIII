using System;
using System.Collections.Generic;
using CapaDatos;
using AccesoDatos;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace CapaNegocios
{
    public class RNPersonal
    {
        public void Registrar(Personal personal)
        {
            string sql = $@"INSERT INTO personal(Nombres,ApellidoPaterno,ApellidoMaterno,NumeroDocumento,Direccion,Telefono,
                     Correo,Celular,Vigencia,CodigoDocumentoPersona,CodigoSistemaPensiones)
                     VALUES('{personal.Nombre}', '{personal.ApellidoPaterno}', '{personal.ApellidoMaterno}',
                    '{personal.NumeroDocumento}',
                    '{personal.Direccion}', '{personal.Telefono}',
                    '{personal.Correo}','{personal.Celular}',1, 
                    {personal.CodigoDocumentoPersona.Codigo},{personal.CodigoSistemaPensiones.Codigo})";
            try
            {
                using (DAL dal = new DAL("MySql.Data.MySqlClient", 
                    ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString))
                {
                    dal.EjecutarOrden(sql);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Actualizar(Personal personal)
        {
            string sql = $@"UPDATE personal 
                SET Nombres = '{personal.Nombre}', ApellidoPaterno = '{personal.ApellidoPaterno}', 
                ApellidoMaterno = '{personal.ApellidoMaterno}', CodigoDocumentoPersona = {personal.CodigoDocumentoPersona.Codigo}, 
                NumeroDocumento = '{personal.NumeroDocumento}', Direccion = '{personal.Direccion}', 
                Telefono = '{personal.Telefono}', Correo = '{personal.Correo}',
                Celular = '{personal.Celular},
                Vigencia = {personal.Vigencia}, CodigoSistemaPensiones = {personal.CodigoSistemaPensiones.Codigo}
                WHERE Codigo = {personal.Codigo}";

            try
            {
                using (DAL cn = new DAL("MySql.Data.MySqlClient", 
                    ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString))
                {
                    cn.EjecutarOrden(sql);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Personal> Listar()
        {
            List<Personal> trabajadores;
            string sql =
                @"SELECT PE.Codigo,PE.Nombres,PE.ApellidoPaterno, PE.ApellidoMaterno,PE.NumeroDocumento,PE.Direccion,
                PE.Telefono,PE.Correo,PE.Celular,PE.Vigencia, SP.Siglas , DP.Nombre,DP.CantidadMinima,DP.CantidadMaxima
                FROM personal PE JOIN sistema_pensiones SP ON SP.Codigo = PE.CodigoSistemaPensiones 
                JOIN documento_Persona DP ON DP.Codigo= PE.CodigoDocumentoPersona ";

            try
            {
                using (MySqlConnection cn = new MySqlConnection(
                    ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            trabajadores = new List<Personal>();
                            while (dr.Read() == true)
                            {
                                trabajadores.Add(
                                    new Personal()
                                    {

                                        Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                        Nombre = dr.GetString(dr.GetOrdinal("Nombres")),
                                        ApellidoPaterno = dr.GetString(dr.GetOrdinal("ApellidoPaterno")),
                                        ApellidoMaterno = dr.GetString(dr.GetOrdinal("ApellidoMaterno")),
                                        NumeroDocumento = dr.GetString(dr.GetOrdinal("NumeroDocumento")),
                                        Direccion = dr.GetString(dr.GetOrdinal("Direccion")),
                                        Telefono = dr.GetString(dr.GetOrdinal("Telefono")),
                                        Correo = dr.GetString(dr.GetOrdinal("Correo")),
                                        Celular = dr.GetString(dr.GetOrdinal("Celular")),
                                        Vigencia = dr.GetBoolean(dr.GetOrdinal("Vigencia")),
                                        CodigoSistemaPensiones = new SistemaPensiones
                                        {
                                            Siglas = dr.GetString(dr.GetOrdinal("Siglas")),
                                        },
                                        CodigoDocumentoPersona = new DocumentoPersona
                                        {
                                            Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                            CantidadMinima = dr.GetInt16(dr.GetOrdinal("CantidadMinima")),
                                            CantidadMaxima = dr.GetInt16(dr.GetOrdinal("CantidadMaxima"))
                                        }
                                    }
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return trabajadores;
        }

        public Personal Buscar(int codigo)
        {
            Personal personal = null;
            string sql = $@"SELECT PE.Codigo,PE.Nombres,PE.ApellidoPaterno, PE.ApellidoMaterno,PE.NumeroDocumento,PE.Direccion,
                PE.Telefono,PE.Correo,PE.Celular,PE.Vigencia, SP.Siglas , DP.Nombre,DP.CantidadMinima,DP.CantidadMaxima
                FROM personal PE JOIN sistema_pensiones SP ON SP.Codigo = PE.CodigoSistemaPensiones 
                JOIN documento_Persona DP ON DP.Codigo= PE.CodigoDocumentoPersona
                WHERE PE.Codigo = {codigo}";
            try
            {
                using (MySqlConnection cn = new MySqlConnection(
                    ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read() == true)
                            {
                                personal = new Personal()
                                {

                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    Nombre = dr.GetString(dr.GetOrdinal("Nombres")),
                                    ApellidoPaterno = dr.GetString(dr.GetOrdinal("ApellidoPaterno")),
                                    ApellidoMaterno = dr.GetString(dr.GetOrdinal("ApellidoMaterno")),
                                    NumeroDocumento = dr.GetString(dr.GetOrdinal("NumeroDocumento")),
                                    Direccion = dr.GetString(dr.GetOrdinal("Direccion")),
                                    Telefono = dr.GetString(dr.GetOrdinal("Telefono")),
                                    Correo = dr.GetString(dr.GetOrdinal("Correo")),
                                    Celular = dr.GetString(dr.GetOrdinal("Celular")),
                                    Vigencia = dr.GetBoolean(dr.GetOrdinal("Vigencia")),
                                    CodigoSistemaPensiones = new SistemaPensiones
                                    {

                                        Siglas = dr.GetString(dr.GetOrdinal("Siglas")),
                                    },
                                    CodigoDocumentoPersona = new DocumentoPersona
                                    {
                                        Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                    }
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return personal;
        }
        
        public List<Personal> ListarVigentes()
        {
            List<Personal> personalVigente;
            string sql =
                @"SELECT PE.Codigo,PE.Nombres,PE.ApellidoPaterno, PE.ApellidoMaterno
                FROM personal PE
                WHERE PE.Vigencia = 1";

            try
            {
                using (MySqlConnection cn = new MySqlConnection(
                    ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            personalVigente = new List<Personal>();
                            while (dr.Read() == true)
                            {
                                personalVigente.Add(
                                    new Personal()
                                    {

                                        Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                        Nombre = dr.GetString(dr.GetOrdinal("Nombres")),
                                        ApellidoPaterno = dr.GetString(dr.GetOrdinal("ApellidoPaterno")),
                                        ApellidoMaterno = dr.GetString(dr.GetOrdinal("ApellidoMaterno"))

                                    }
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return personalVigente;
        }

        public List<Personal> ListarPorSistemaPensiones(int codSistema)
        {
            List<Personal> listado;
            string sql = $@"SELECT PE.Codigo,PE.Nombres,PE.ApellidoPaterno, PE.ApellidoMaterno, 
                PE.NumeroDocumento
                FROM personal PE
                WHERE PE.CodigoSistemaPensiones= '{codSistema}'";

            try
            {
                using (MySqlConnection cn = new MySqlConnection(
                    ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            listado = new List<Personal>();
                            while (dr.Read() == true)
                            {
                                listado.Add(
                                    new Personal()
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                        Nombre = dr.GetString(dr.GetOrdinal("Nombres")),
                                        ApellidoPaterno = dr.GetString(dr.GetOrdinal("ApellidoPaterno")),
                                        ApellidoMaterno = dr.GetString(dr.GetOrdinal("ApellidoMaterno")),
                                        NumeroDocumento = dr.GetString (dr.GetOrdinal("NumeroDocumento"))
                                    }
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listado;
        }
    }
}
