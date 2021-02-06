using AccesoDatos;
using CapaDatos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace CapaNegocios
{
    public class RNMedioPago
    {
        public void Registrar(MedioPago pago)
        {
            string sql = $@"INSERT INTO mediopago(Nombre,Vigencia,CodigoSUNAT)
                     VALUES('{pago.Nombre}',1, '{pago.CodigoSunat}')";
            try
            {
                using (DAL dal = new DAL("MySql.Data.MySqlClient",ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString))
                {
                    dal.EjecutarOrden(sql);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Actualizar(MedioPago pago)
        {
            string sql = $@"UPDATE mediopago 
                SET Nombre = '{pago.Nombre}', CodigoSUNAT = '{pago.CodigoSunat}',
                Vigencia = '{pago.Vigencia}'
                WHERE Codigo = '{pago.Codigo}'";
            
            try
            {
                using (DAL cn = new DAL("MySql.Data.MySqlClient", ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString))
                {
                    cn.EjecutarOrden(sql);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<MedioPago> Listar()
        {
            List<MedioPago> pagos;
            string sql =
                @"SELECT P.Codigo, P.Nombre, P.CodigoSUNAT,P.Vigencia
                FROM mediopago P";
         try
            {
                using (MySqlConnection cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            pagos = new List<MedioPago>();
                            while (dr.Read() == true)
                            {
                                pagos.Add(
                                    new MedioPago()
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                        Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                        CodigoSunat = dr.GetString(dr.GetOrdinal("CodigoSUNAT")),
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

            return pagos;
        }

        public MedioPago Buscar(int codigo)
        {
            MedioPago pago = null;
            string sql =$@"SELECT P.Codigo, P.Nombre, P.CodigoSUNAT,P.Vigencia
                FROM mediopago P
              WHERE P.Codigo = {codigo}";
            
            try
            {
                using (MySqlConnection cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read() == true)
                            {
                                pago = new MedioPago()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                    CodigoSunat = dr.GetString(dr.GetOrdinal("CodigoSUNAT")),
                                    Vigencia= dr.GetBoolean(dr.GetOrdinal("Vigencia"))
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
            return pago;
        }


        public List<MedioPago> ListarVigentes()
        {
            List<MedioPago> pagolVigente;
            string sql =
                @"SELECT  P.Codigo, P.Nombre, P.CodigoSUNAT,P.Vigencia
                FROM mediopago P;
                WHERE P.Vigencia = 1";
         try
            {
                using (MySqlConnection cn = new MySqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            pagolVigente = new List<MedioPago>();
                            while (dr.Read() == true)
                            {
                                pagolVigente.Add(
                                    new MedioPago()
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                        Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
                                        CodigoSunat = dr.GetString(dr.GetOrdinal("CodigoSUNAT"))
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

            return pagolVigente;
        }
    }
}
