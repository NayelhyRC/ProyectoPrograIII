using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using AccesoDatos;
using CapaDatos;
using System.Configuration;

namespace CapaNegocios
{
    public class RNDocumentoPersona
    {
        public void Registrar(DocumentoPersona doc)
        {
            string sql = $@"INSERT INTO documento_persona(Nombre,CodigoSUNAT,Tipo,CantidadMinima,CantidadMaxima,Vigencia)
                    VALUES('{doc.Nombre}', '{doc.CodigoSunat}','{doc.Tipo}',
                    '{doc.CantidadMinima}','{doc.CantidadMaxima}','{doc.Vigencia}')";

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

        public void Actualizar(DocumentoPersona doc)
        {
            string sql = $@"UPDATE documento_persona 
                SET Nombre = '{doc.Nombre}', CodigoSUNAT = '{doc.CodigoSunat}', 
                Tipo = '{doc.Tipo}', CantidadMinima = '{doc.CantidadMinima}', 
                CantidadMaxima = '{doc.CantidadMaxima}',Vigencia = '{doc.Vigencia}'
                WHERE Codigo = '{doc.Codigo}'";

            string con = "server=127.0.0.1;user id=root;database=sistemaventas_plataforma";

            try
            {
                using (DAL cn = new DAL("MySql.Data.MySqlClient", con))
                {
                    cn.EjecutarOrden(sql);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DocumentoPersona> Listar()
        {
            List<DocumentoPersona> docs;
            string sql = @"SELECT D.Codigo,D.Nombre,D.CodigoSUNAT,D.Tipo,D.CantidadMaxima,D.CantidadMinima,D.Vigencia
              FROM documento_persona D";

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
                            docs = new List<DocumentoPersona>();
                            while (dr.Read() == true)
                            {
                                docs.Add(
                                    new DocumentoPersona()
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                        Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                        CodigoSunat= dr.GetString(dr.GetOrdinal("CodigoSUNAT")),
                                        Tipo= dr.GetString(dr.GetOrdinal("Tipo")),
                                        CantidadMaxima=dr.GetInt16(dr.GetOrdinal("CantidadMaxima")),
                                        CantidadMinima=dr.GetInt16(dr.GetOrdinal("CantidadMinima")),
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

            return docs;
        }

        public DocumentoPersona Buscar(int codigo)
        {
            DocumentoPersona doc= null;
            string sql = $@"SELECT D.Codigo,D.Nombre,D.CodigoSUNAT,D.Tipo,D.CantidadMaxima,D.CantidadMinima,D.Vigencia
              FROM documento_persona D
              WHERE D.Codigo = '{codigo}'";

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
                                doc = new DocumentoPersona()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                    CodigoSunat = dr.GetString(dr.GetOrdinal("CodigoSUNAT")),
                                    Tipo = dr.GetString(dr.GetOrdinal("Tipo")),
                                    CantidadMaxima = dr.GetInt16(dr.GetOrdinal("CantidadMaxima")),
                                    CantidadMinima = dr.GetInt16(dr.GetOrdinal("CantidadMinima")),
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
            return doc;
        }

        public List<DocumentoPersona> ListarVigentes()
        {
            List<DocumentoPersona> docs;
            string sql = @"SELECT D.Codigo,D.Nombre,D.Tipo,D.CantidadMaxima,D.CantidadMinima
              FROM documento_persona D WHERE D.Vigencia = 1";
            
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
                            docs = new List<DocumentoPersona>();
                            while (dr.Read() == true)
                            {
                                docs.Add(
                                    new DocumentoPersona()
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                        Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                        Tipo = dr.GetString(dr.GetOrdinal("Tipo")),
                                        CantidadMaxima = dr.GetInt16(dr.GetOrdinal("CantidadMaxima")),
                                        CantidadMinima = dr.GetInt16(dr.GetOrdinal("CantidadMinima")),
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

            return docs;
        }
    }
}
