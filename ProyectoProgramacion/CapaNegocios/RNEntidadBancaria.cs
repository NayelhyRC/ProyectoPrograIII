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
    public class RNEntidadBancaria
    {
        public void Registrar(EntidadBancaria EntidadBancaria)
        {
            string sql = $@"INSERT INTO entidad_bancaria (RazonSocial,Siglas,Vigencia)
                    VALUES('{EntidadBancaria.RazonSocial}', '{EntidadBancaria.Siglas}',{EntidadBancaria.Vigencia})";

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

        public void Actualizar(EntidadBancaria EntidadBancaria)
        {
            string sql = $@"UPDATE entidad_bancaria 
                SET RazonSocial = '{EntidadBancaria.RazonSocial}', Siglas = '{EntidadBancaria.Siglas}', 
                Vigencia = {EntidadBancaria.Vigencia}
                WHERE Codigo = '{EntidadBancaria.Codigo}'";

            try
            {using (DAL cn = new DAL("MySql.Data.MySqlClient",
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

        public List<EntidadBancaria> Listar()
        {
            List<EntidadBancaria> entidades;
            string sql = @"SELECT EB.Codigo,EB.RazonSocial,EB.Siglas,EB.Vigencia
              FROM entidad_bancaria EB";
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
                            entidades = new List<EntidadBancaria>();
                            while (dr.Read() == true)
                            {
                                entidades.Add(
                                    new EntidadBancaria()
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                        RazonSocial = dr.GetString(dr.GetOrdinal("RazonSocial")),
                                        Siglas = dr.GetString(dr.GetOrdinal("Siglas")),
                                        Vigencia = dr.GetBoolean(dr.GetOrdinal("Vigencia"))
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

            return entidades;
        }

        public EntidadBancaria Buscar(int codigo)
        {
            EntidadBancaria entidadBancaria = null;
            string sql = $@"SELECT EB.Codigo, EB.RazonSocial,EB.Siglas,EB.Vigencia
              FROM entidad_bancaria EB
            WHERE EB.Codigo = '{codigo}'";

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
                                entidadBancaria = new EntidadBancaria()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    RazonSocial = dr.GetString(dr.GetOrdinal("RazonSocial")),
                                    Siglas = dr.GetString(dr.GetOrdinal("Siglas")),
                                    Vigencia = dr.GetBoolean(dr.GetOrdinal("Vigencia"))
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
            return entidadBancaria;
        }
    }
}
