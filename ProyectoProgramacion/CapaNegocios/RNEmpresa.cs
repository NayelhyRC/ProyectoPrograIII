using System;
using AccesoDatos;
using CapaDatos;
using System.Configuration;
using System.Data;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
namespace CapaNegocios
{
    public class RNEmpresa
    {
        public void Registrar(Empresa Empresa)
        {
            string sql = $@"INSERT INTO Empresa(RazonSocial,RUC,Facebook,Instagram,Youtube,Whatsapp,Correo,Logo,Vigencia)
                    VALUES('{Empresa.RazonSocial}', '{Empresa.RUC}','{Empresa.Facebook}',
                    '{Empresa.Instagram}','{Empresa.YouTube}','{Empresa.Whatsapp}','{Empresa.Correo}','{Empresa.Logo}',{Empresa.Vigencia})";

            try
            {
                using (DAL dal = new DAL("System.Data.SQLClient",
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

        public void Actualizar(Empresa Empresa)
        {
            string sql = $@"UPDATE Empresa 
                SET RazonSocial = '{Empresa.RazonSocial}', RUC = '{Empresa.RUC}', 
                Facebook = '{Empresa.Facebook}', Instagram = '{Empresa.Instagram}', 
                Youtube = '{Empresa.YouTube}', Whatsapp = '{Empresa.Whatsapp}', 
                Correo = '{Empresa.Correo}', Logo = '{Empresa.Logo}',
                Vigencia = {Empresa.Vigencia}
                WHERE Codigo = '{Empresa.Codigo}'";

            try
            {
                using (DAL cn = new DAL("System.Data.SQLClient",
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

        public List<Empresa> Listar()
        {
            List<Empresa> empresas;
            string sql =@"SELECT E.Codigo,E.RazonSocial,E.RUC,E.Facebook,E.Instagram,E.Youtube,E.Whatsapp,E.Correo,E.Logo,E.Vigencia
              FROM empresa E";

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
                            empresas = new List<Empresa>();
                            while (dr.Read() == true)
                            {
                                empresas.Add(
                                    new Empresa()
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                        RazonSocial = dr.GetString(dr.GetOrdinal("RazonSocial")),
                                        RUC = dr.GetString(dr.GetOrdinal("RUC")),
                                        Facebook = dr.GetString(dr.GetOrdinal("Facebook")),
                                        Instagram = dr.GetString(dr.GetOrdinal("Instagram")),
                                        YouTube = dr.GetString(dr.GetOrdinal("Youtube")),
                                        Whatsapp = dr.GetString(dr.GetOrdinal("Whatsapp")),
                                        Correo = dr.GetString(dr.GetOrdinal("Correo")),
                                        Logo = dr.GetString(dr.GetOrdinal("Logo")),
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

            return empresas;
        }

        public Empresa Buscar(int codigo)
        {
            Empresa empresa=null;
            string sql =$@"SELECT E.Codigo, E.RazonSocial,E.RUC,E.Facebook,E.Instagram,E.Youtube,E.Whatsapp,E.Correo,E.Logo,E.Vigencia
              FROM empresa E
              WHERE E.Codigo = '{codigo}'";

            try
            {
                 using (MySqlConnection cn = new MySqlConnection(
                    ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql,cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read() == true)
                            {
                                empresa = new Empresa()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    RazonSocial = dr.GetString(dr.GetOrdinal("RazonSocial")),
                                    RUC = dr.GetString(dr.GetOrdinal("RUC")),
                                    Facebook = dr.GetString(dr.GetOrdinal("Facebook")),
                                    Instagram = dr.GetString(dr.GetOrdinal("Instagram")),
                                    YouTube = dr.GetString(dr.GetOrdinal("Youtube")),
                                    Whatsapp = dr.GetString(dr.GetOrdinal("Whatsapp")),
                                    Correo = dr.GetString(dr.GetOrdinal("Correo")),
                                    Logo = dr.GetString(dr.GetOrdinal("Logo")),
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
            return empresa;
        }

        public List<Empresa> ListarVigentes()
        {  
            List<Empresa> empresas;
            string sql = @"SELECT E.Codigo,E.RazonSocial,E.RUC
              FROM empresa E WHERE E.Vigencia = 1";
            
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
                            empresas = new List<Empresa>();
                            while (dr.Read() == true)
                            {
                                empresas.Add(
                                    new Empresa()
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                        RazonSocial = dr.GetString(dr.GetOrdinal("RazonSocial")),
                                        RUC = dr.GetString(dr.GetOrdinal("RUC")),
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

            return empresas;
        }
    }
}
