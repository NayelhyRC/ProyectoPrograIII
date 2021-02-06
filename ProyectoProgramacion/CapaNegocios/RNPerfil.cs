using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Configuration;
using AccesoDatos;
using MySql.Data.MySqlClient;

namespace CapaNegocios
{
    public class RNPerfil
    {
        public void Registrar(Perfil pl)
        {
            string sql = $@"INSERT INTO perfil( Nombre, Descripcion, Vigencia)
            VALUES('{pl.Nombre}', '{pl.Descripcion}','{pl.Vigencia}')";

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
        
        public void Actualizar(Perfil pl)
        {
            string sql = $@"UPDATE perfil
                SET Nombre = '{pl.Nombre}', Descripcion = '{pl.Descripcion}', Vigencia = {pl.Vigencia}
                WHERE Codigo = '{pl.Codigo}'";
            
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

        public List<Perfil> Listar()
        {
            List<Perfil> pls;
            string sql = @"SELECT P.Codigo,P.Nombre,P.Descripcion, P.Vigencia
                FROM perfil P ";
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
                            pls = new List<Perfil>();
                            while (dr.Read() == true)
                            {
                                pls.Add(

                                    new Perfil()
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                        Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                        Descripcion = dr.GetString(dr.GetOrdinal("Descripcion")),
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

            return pls;
        }

        public Perfil Buscar(int codigo)
        {
            Perfil pl = null;
            string sql = $@"SELECT P.Codigo,P.Nombre,P.Descripcion, P.Vigencia
                        FROM perfil P 
                      WHERE P.Codigo = '{codigo}'";
            
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
                                pl = new Perfil()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                    Descripcion = dr.GetString(dr.GetOrdinal("Descripcion")),
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

            return pl;
        }

        public List<Perfil> ListarVigentes()
        {
            List<Perfil> pls;
            string sql = @"SELECT P.Codigo,P.Nombre
                FROM perfil P 
                WHERE P.Vigencia = 1";
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
                            pls = new List<Perfil>();
                            while (dr.Read() == true)
                            {
                                pls.Add(

                                    new Perfil()
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

            return pls;
        }
    }
}
