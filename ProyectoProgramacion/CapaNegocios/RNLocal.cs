using System;
using AccesoDatos;
using CapaDatos;
using System.Configuration;
using System.Data;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
namespace CapaNegocios
{
    public class RNLocal
    {


        public void Registrar(Local Local)
        {
            string sql = $@"INSERT INTO Local( CodigoEmpresa, Nombre, Direccion, Telefono, Vigencia)
            VALUES({Local.Empresa.Codigo}, '{Local.Nombre}', '{Local.Direccion}', '{Local.Telefono}', '{Local.Vigencia}')";

            try
            {
                using (MySqlConnection cn = new MySqlConnection(
                    ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public void Actualizar(Local Local)
        {
            string sql = $@"UPDATE Local
                SET Nombre = '{Local.Nombre}', Direccion = '{Local.Direccion}', 
                Telefono = '{Local.Telefono}', Vigencia = '{Local.Vigencia}'
                WHERE Codigo = '{Local.Codigo}'";
            
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

        public List<Local> Listar()
        {
            List<Local> locales;
            string sql = @"SELECT L.Codigo,L.Nombre, L.Direccion, L.Telefono,L.CodigoEmpresa,E.RazonSocial,L.Vigencia
                FROM Local L JOIN empresa E ON E.Codigo=L.CodigoEmpresa";

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
                            locales = new List<Local>();
                            while (dr.Read() == true)
                            {
                                locales.Add(

                                    new Local()
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                        Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                        Direccion = dr.GetString(dr.GetOrdinal("Direccion")),
                                        Telefono = dr.GetString(dr.GetOrdinal("Telefono")),
                                        Empresa = new Empresa()
                                        {
                                            Codigo = dr.GetInt16(dr.GetOrdinal("CodigoEmpresa")),
                                            RazonSocial=dr.GetString(dr.GetOrdinal("RazonSocial"))
                                        },
                                        Vigencia=dr.GetBoolean(dr.GetOrdinal("Vigencia"))
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

            return locales;
        }

        public Local Buscar(int codigo)
        {
            Local local = null;
            string sql = $@"SELECT L.Codigo,L.Nombre,L.Direccion,L.Telefono, L.Vigencia,L.CodigoEmpresa
                      FROM Local L
                      WHERE L.Codigo = '{codigo}'";
           
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
                                local = new Local()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                    Direccion = dr.GetString(dr.GetOrdinal("Direccion")),
                                    Telefono = dr.GetString(dr.GetOrdinal("Telefono")),
                                    Vigencia = dr.GetBoolean(dr.GetOrdinal("Vigencia")),
                                    Empresa = new Empresa
                                    {
                                        Codigo=dr.GetInt16(dr.GetOrdinal("CodigoEmpresa"))
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

            return local;
        }

        public List<Local> ListarVigentes()
        {
            List<Local> locales;
            string sql =
                @"SELECT L.Codigo,L.Nombre
              FROM local L
              WHERE L.Vigencia = 1";

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
                            locales = new List<Local>();
                            while (dr.Read() == true)
                            {
                                locales.Add(

                                    new Local()
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                        Nombre = dr.GetString(dr.GetOrdinal("Nombre"))
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

            return locales;
        }
    }
}
