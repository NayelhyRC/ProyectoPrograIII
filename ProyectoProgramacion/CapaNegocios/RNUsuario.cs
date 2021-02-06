using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using AccesoDatos;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace CapaNegocios
{
    public class RNUsuario
    {
        public Usuario InicioSesion(string Nombre, string contraseña)
        {
            Usuario us = null;
            try
            {
                string sql = $@"SELECT U.Codigo,U.CodigoPersonal, P.Nombres, P.ApellidoPaterno,P.ApellidoMaterno,
                            U.CodigoPerfil, Pl.Nombre, PL.Descripcion,
                            U.CodigoLocal, L.Nombre,
                            U.Nombre,U.Clave,U.Tipo,U.Vigencia
                            FROM usuario U JOIN personal P ON P.Codigo= U.CodigoPersonal JOIN perfil PL ON PL.Codigo=U.CodigoPerfil
                            JOIN local L ON L.Codigo= U.CodigoLocal
                            WHERE U.Nombre = '{Nombre}' AND U.Clave = '{contraseña}'";
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
                                us = new Usuario()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    CodigoPersonal = new Personal
                                    {
                                        Codigo = dr.GetUInt16(dr.GetOrdinal("CodigoPersonal")),
                                        Nombre = dr.GetString(dr.GetOrdinal("Nombres")),
                                        ApellidoPaterno = dr.GetString(dr.GetOrdinal("ApellidoPaterno")),
                                        ApellidoMaterno = dr.GetString(dr.GetOrdinal("ApellidoMaterno")),
                                    },
                                    CodigoPerfil = new Perfil
                                    {
                                        Codigo = dr.GetUInt16(dr.GetOrdinal("CodigoPerfil")),
                                        Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                        Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"))
                                    },
                                    CodigoLocal = new Local
                                    {
                                        Codigo = dr.GetUInt16(dr.GetOrdinal("CodigoLocal")),
                                        Nombre = dr.GetString(dr.GetOrdinal("Nombre"))
                                    },
                                    Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                    Clave = dr.GetString(dr.GetOrdinal("Clave")),
                                    Tipo = dr.GetString(dr.GetOrdinal("Tipo")),
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
            return us;
        }

        public void Registrar(Usuario Usuario)
        {
            string sql = $@"INSERT INTO Usuario(CodigoPersonal, CodigoPerfil, Nombre, Clave, Tipo, CodigoLocal, Vigencia)
            VALUES('{Usuario.CodigoPersonal}','{Usuario.Nombre}',
                    '{Usuario.Clave}','{Usuario.Tipo}','{Usuario.CodigoLocal}','{Usuario.Vigencia}', 1)";

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

        public void Actualizar(Usuario Usuario)
        {
            string sql = $@"UPDATE Usuario
                SET CodigoPersonal = '{Usuario.CodigoPersonal}', 
                Nombre = '{Usuario.Nombre}', Clave = '{Usuario.Clave}', 
                Tipo  = '{Usuario.Tipo}', CodigoLocal = '{Usuario.CodigoLocal}', 
                Vigencia = '{Usuario.Vigencia}'";

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

        public List<Usuario> Listar()
        {
            List<Usuario> usuarios = null;
            string sql = @"SELECT U.Codigo,U.CodigoPersonal, P.Nombres, P.ApellidoPaterno,P.ApellidoMaterno,
                            U.CodigoPerfil, Pl.Nombre, PL.Descripcion,
                            U.CodigoLocal, L.Nombre,
                            U.Nombre,U.Clave,U.Tipo,U.Vigencia
                            FROM usuario U JOIN personal P ON P.Codigo= U.CodigoPersonal JOIN perfil PL ON PL.Codigo=U.CodigoPerfil
                            JOIN local L ON L.Codigo= U.CodigoLocal";


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
                            usuarios = new List<Usuario>();
                            while (dr.Read() == true)
                            {
                                usuarios.Add(
                                    new Usuario
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                        CodigoPersonal = new Personal
                                        {
                                            Codigo = dr.GetUInt16(dr.GetOrdinal("CodigoPersonal")),
                                            Nombre = dr.GetString(dr.GetOrdinal("Nombres")),
                                            ApellidoPaterno = dr.GetString(dr.GetOrdinal("ApellidoPaterno")),
                                            ApellidoMaterno = dr.GetString(dr.GetOrdinal("ApellidoMaterno")),
                                        },
                                        CodigoPerfil = new Perfil
                                        {
                                            Codigo = dr.GetUInt16(dr.GetOrdinal("CodigoPerfil")),
                                            Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                            Descripcion = dr.GetString(dr.GetOrdinal("Descripcion"))
                                        },
                                        CodigoLocal = new Local
                                        {
                                            Codigo = dr.GetUInt16(dr.GetOrdinal("CodigoLocal")),
                                            Nombre = dr.GetString(dr.GetOrdinal("Nombre"))
                                        },
                                        Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                        Clave = dr.GetString(dr.GetOrdinal("Clave")),
                                        Tipo = dr.GetString(dr.GetOrdinal("Tipo")),
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

            return usuarios;


        }

        public Usuario Buscar(int codigo)
        {
            Usuario usuario = null;
            string sql = $@"SELECT U.Codigo,U.CodigoPersonal,
                            U.CodigoPerfil,
                            U.CodigoLocal,
                            U.Nombre,U.Clave,U.Tipo,U.Vigencia
                            FROM usuario U 
                      WHERE U.Codigo = '{codigo}'";
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
                                usuario = new Usuario()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    CodigoPersonal = new Personal
                                    {
                                        Codigo = dr.GetUInt16(dr.GetOrdinal("CodigoPersonal"))
                                    },
                                    CodigoPerfil = new Perfil
                                    {
                                        Codigo = dr.GetUInt16(dr.GetOrdinal("CodigoPerfil"))
                                    },
                                    CodigoLocal = new Local
                                    {
                                        Codigo = dr.GetUInt16(dr.GetOrdinal("CodigoLocal"))
                                    },
                                    Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                    Clave = dr.GetString(dr.GetOrdinal("Clave")),
                                    Tipo = dr.GetString(dr.GetOrdinal("Tipo")),
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

            return usuario;
        }

        public List<Usuario> ListarVigentes()
        {
            List<Usuario> usuarios;
            string sql = @"SELECT U.Codigo,U.Nombre,U.Clave,U.Tipo,U.Vigencia
                    FROM usuario U WHERE U.Vigencia = 1";

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
                            usuarios = new List<Usuario>();
                            while (dr.Read() == true)
                            {
                                usuarios.Add(
                                    new Usuario()
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                        Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                        Clave = dr.GetString(dr.GetOrdinal("Clave")),
                                        Tipo = dr.GetString(dr.GetOrdinal("Tipo")),
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

            return usuarios;
        }
    } 
}
