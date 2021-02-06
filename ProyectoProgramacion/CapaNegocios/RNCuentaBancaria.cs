using AccesoDatos;
using CapaDatos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;

namespace CapaNegocios
{
    public class RNCuentaBancaria
    {
        public void Registrar(CuentaBancaria cuenta)
        {
            string sql = $@"INSERT INTO cuenta_bancaria(CodigoEmpresa, CodigoEntidadFinanciera, CCI, NumeroCuenta, 
                    TipoMoneda , Nombre  , Vigencia)
                     VALUES({cuenta.CodigoEmpresa}, {cuenta.CodigoEntidadBancaria}, '{cuenta.CCI}',
                    '{cuenta.NumeroCuenta}', '{cuenta.TipoMoneda}',
                    '{cuenta.NombreP}', {cuenta.Vigencia})";
                    
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

        public void Actualizar(CuentaBancaria cuenta)
        {
            string sql = $@"UPDATE cuenta_bancaria 
                SET CodigoEmpresa = '{cuenta.CodigoEmpresa}',
                CodigoEntidadFinanciera = '{cuenta.CodigoEntidadBancaria}', 
                CCI = '{cuenta.CCI}', 
                NumeroCuenta = '{cuenta.NumeroCuenta}', 
                tipoMoneda = '{cuenta.TipoMoneda},
                nombre = '{cuenta.NombreP}'
                Vigencia = '{cuenta.Vigencia}'
                WHERE Codigo = '{cuenta.Codigo}'";

            //string con = "server=127.0.0.1;user id=root;database=bdsistemaventas_plataforma";
            try
            {
                //using (DAL cn = new DAL("MySql.Data.MySqlClient", con))
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

        public List<CuentaBancaria> Listar()
        {
            List<CuentaBancaria> cuentas;
            string sql = $@"SELECT C.Codigo, C.CodigoEmpresa, C.CodigoEntidadFinanciera, C.CCI, 
                C.NumeroCuenta, C.TipoMoneda , C.Nombre  , C.Vigencia
                FROM cuenta_bancaria C";

            //string con = "server = localhost; user id = root; database = sistemaventas_plataforma";

         try
            {
                //using (MySqlConnection cn = new MySqlConnection(con))
                using (MySqlConnection cn = new MySqlConnection(
                    ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString))
                {
                    cn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            cuentas = new List<CuentaBancaria>();
                            while (dr.Read() == true)
                            {
                                cuentas.Add(
                                    new CuentaBancaria()
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                        CCI = dr.GetString(dr.GetOrdinal("ApellidoMaterno")),
                                        NumeroCuenta = dr.GetString(dr.GetOrdinal("DNI")),
                                        TipoMoneda = dr.GetChar(dr.GetOrdinal("Tipo")),
                                        NombreP = dr.GetString(dr.GetOrdinal("Telefono")),
                                        Vigencia = dr.GetBoolean(dr.GetOrdinal("Vigente")),

                                        CodigoEmpresa = new Empresa
                                        {
                                            Codigo = dr.GetInt16(dr.GetOrdinal("CodigoEmpresa")),
                                        },

                                        CodigoEntidadBancaria = new EntidadBancaria
                                        {
                                            Codigo = dr.GetInt16(dr.GetOrdinal("CodigoEntidadFinanciera")),
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

            return cuentas;
        }

        public CuentaBancaria Buscar(int codigo)
        {
            CuentaBancaria cuenta = null;
            string sql = $@"SELECT C.Codigo, C.CodigoEmpresa, C.CodigoEntidadFinanciera, C.CCI, C.NumeroCuenta, 
                        C.TipoMoneda , C.Nombre  , C.Vigencia
                        FROM cuenta_bancaria C
                        WHERE C.Codigo = {codigo}";

            //string con = "server=127.0.0.1;user id=root;database=bdsistemaventas_plataforma";
            try
            {
                //using (MySqlConnection cn = new MySqlConnection(con))
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
                                cuenta = new CuentaBancaria()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    CCI = dr.GetString(dr.GetOrdinal("ApellidoMaterno")),
                                    NumeroCuenta = dr.GetString(dr.GetOrdinal("DNI")),
                                    TipoMoneda = dr.GetChar(dr.GetOrdinal("Tipo")),
                                    NombreP = dr.GetString(dr.GetOrdinal("Telefono")),
                                    Vigencia = dr.GetBoolean(dr.GetOrdinal("Vigente")),
                                    CodigoEmpresa = new Empresa
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("CodigoEmpresa")),
                                    },
                                    CodigoEntidadBancaria = new EntidadBancaria
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("CodigoEntidadFinanciera")),
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
            return cuenta;
        }
        
        public List<CuentaBancaria> ListarVigentes()
        {
            List<CuentaBancaria> cuentas;
            string sql = $@"SELECT C.Codigo, C.CodigoEmpresa, C.CodigoEntidadFinanciera, C.CCI, C.NumeroCuenta, 
                        C.TipoMoneda , C.Nombre, C.Vigencia
                        FROM cuenta_bancaria C;
                        WHERE C.Vigente = 1";

                        //string con = "server = 127.0.0.1; user id = root; database = bdsistemaventas_plataforma";
             try
             {
                    //using (MySqlConnection cn = new MySqlConnection(con))
                   using (MySqlConnection cn = new MySqlConnection(
                        ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString))
                    {
                        cn.Open();
                        using (MySqlCommand cmd = new MySqlCommand(sql, cn))
                        {
                            using (MySqlDataReader dr = cmd.ExecuteReader())
                            {
                                cuentas = new List<CuentaBancaria>();
                                while (dr.Read() == true)
                                {
                                    cuentas.Add(
                                        new CuentaBancaria()
                                        {
                                            Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                            CCI = dr.GetString(dr.GetOrdinal("ApellidoMaterno")),
                                            NumeroCuenta = dr.GetString(dr.GetOrdinal("DNI")),
                                            TipoMoneda = dr.GetChar(dr.GetOrdinal("Tipo")),
                                            NombreP = dr.GetString(dr.GetOrdinal("Telefono")),
                                            Vigencia = dr.GetBoolean(dr.GetOrdinal("Vigente")),
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

            return cuentas;
        }
    }
}
