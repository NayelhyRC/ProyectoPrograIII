using System;
using CapaDatos;
using AccesoDatos;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace CapaNegocios
{
    public class RNSistemaPensiones
    {
        public void Registrar(SistemaPensiones SistemaPensiones)
        {
            string sql = $@"INSERT INTO sistema_pensiones(Nombre,Siglas,Vigencia)
                            VALUES('{SistemaPensiones.Nombre}', '{SistemaPensiones.Siglas}','{SistemaPensiones.Vigencia}')";

            try
            {using (DAL dal = new DAL("MySql.Data.MySqlClient",
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

        public void Actualizar(SistemaPensiones SistemaPensiones)
        {
            string sql = $@"UPDATE sistema_pensiones
                 SET Nombre = '{SistemaPensiones.Nombre}', Siglas = '{SistemaPensiones.Siglas}', 
                 Vigencia = '{SistemaPensiones.Vigencia}'
                 WHERE Codigo = '{SistemaPensiones.Codigo}'";
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

        public SistemaPensiones Buscar(int codigo)
        {
            SistemaPensiones sistemaPensiones = null;
            string sql = $@"SELECT S.Codigo,S.Nombre,S.Siglas, S.Vigencia 
                      FROM sistema_pensiones S
                      WHERE S.Codigo = '{codigo}'";

            
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
                                sistemaPensiones = new SistemaPensiones()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    Nombre = dr.GetString(dr.GetOrdinal("Nombres")),
                                    Siglas = dr.GetString(dr.GetOrdinal("ApellidoPaterno")),
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

            return sistemaPensiones;
        }

        public List<SistemaPensiones> Listar()
        {
            List<SistemaPensiones> sistemaPensiones;
            string sql = @"SELECT S.Codigo,S.Nombre,S.Siglas,S.Vigencia FROM sistema_pensiones S";

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
                            sistemaPensiones = new List<SistemaPensiones>();
                            while (dr.Read() == true)
                            {
                                sistemaPensiones.Add(
                                    new SistemaPensiones()
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                        Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
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
            return sistemaPensiones;

        }

        public List<SistemaPensiones> ListarVigentes()
        {
            List<SistemaPensiones> spVigente;
            string sql = @"SELECT SP.Codigo,SP.Siglas
                FROM sistema_pensiones SP
                WHERE SP.Vigencia = 1";

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
                            spVigente = new List<SistemaPensiones>();
                            while (dr.Read() == true)
                            {
                                spVigente.Add(new SistemaPensiones
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    Siglas = dr.GetString(dr.GetOrdinal("Siglas"))
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

            return spVigente;
        }
    }
}

