using System;
using System.Collections.Generic;
using CapaDatos;
using AccesoDatos;
using System.Configuration;
using MySql.Data.MySqlClient;


namespace CapaNegocios
{
    public class RNLocalPersonal
    {
        public bool Registrar(LocalPersonal localPer)
        {
            string sql = $@"INSERT INTO localpersonal(CodigoPersonal, CodigoLocal, FechaInicio, FechaFin, Cargo, CorreoEmpresarial,
                        CelularEmpresarial, Sueldo, Vigencia)
                        VALUES({localPer.Personal.Codigo}, '{localPer.Local.Codigo}', '{localPer.FechaInicio}', 
                        '{localPer.FechaFin}', '{localPer.Cargo}', '{localPer.CorreoEmpresarial}', '{localPer.CelularEmpresarial}',
                        '{localPer.Sueldo}', {localPer.Vigencia})";

            try
            {
                using (DAL dal = new DAL("MySql.Data.MySqlClient",
                    ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString))
                {
                    dal.EjecutarOrden(sql);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        public bool Actualizar(LocalPersonal localPer)
        {
            
            string sql = $@"UPDATE localpersonal
                SET CodigoPersonal = {localPer.Personal.Codigo}, CodigoLocal = {localPer.Local.Codigo}, Cargo = '{localPer.Cargo}',
                Sueldo = {localPer.Sueldo}, CorreoEmpresarial = '{localPer.CorreoEmpresarial}', CelularEmpresarial = '{localPer.CelularEmpresarial}',
                Vigencia = {localPer.Vigencia}
                WHERE Codigo = {localPer.Codigo}";

            try
            {
                using (DAL cn = new DAL("MySql.Data.MySqlClient",
                    ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString))
                {
                    cn.EjecutarOrden(sql);
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        public List<LocalPersonal> Listar()
        {
            List<LocalPersonal> lista = null;
            string sql = $@"SELECT L.Codigo, O.Nombre, E.RazonSocial, P.ApellidoPaterno, P.ApellidoMaterno, P.Nombres, P.NumeroDocumento,
                L.FechaInicio, L.FechaFin, L.Sueldo, L.Vigencia, L.Cargo, L.CelularEmpresarial, L.CorreoEmpresarial
            	FROM localpersonal L JOIN personal P ON L.CodigoPersonal = P.Codigo JOIN local O ON L.CodigoLocal = O.Codigo
                JOIN empresa E on E.Codigo = O.CodigoEmpresa
            	ORDER BY P.ApellidoPaterno, P.ApellidoMaterno, P.Nombres";

            try
            {
                using (MySqlConnection cn = new MySqlConnection(
                    ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString))
                {
                    cn.Open();
                    using(MySqlCommand cmd = new MySqlCommand(sql, cn))
                    {
                        using (MySqlDataReader dr = cmd.ExecuteReader())
                        {
                            lista = new List<LocalPersonal>();
                            while (dr.Read() == true)
                            {
                                lista.Add(
                                    new LocalPersonal
                                    {
                                        Codigo = dr.GetInt32(dr.GetOrdinal("Codigo")),
                                        FechaInicio = dr.GetString(dr.GetOrdinal("FechaInicio")),
                                        Sueldo = dr.GetFloat(dr.GetOrdinal("Sueldo")),
                                        Cargo = dr.GetString(dr.GetOrdinal("Cargo")),
                                        CelularEmpresarial = dr.GetString(dr.GetOrdinal("CelularEmpresarial")),
                                        CorreoEmpresarial = dr.GetString(dr.GetOrdinal("CorreoEmpresarial")),
                                        Vigencia = dr.GetBoolean(dr.GetOrdinal("Vigencia")),
                                        FechaFin = dr.GetString(dr.GetOrdinal("FechaFin")),
                                        Personal = new Personal
                                        {
                                            Nombre = dr.GetString(dr.GetOrdinal("Nombres")),
                                            ApellidoPaterno = dr.GetString(dr.GetOrdinal("ApellidoPaterno")),
                                            ApellidoMaterno = dr.GetString(dr.GetOrdinal("ApellidoMaterno")),
                                            NumeroDocumento = dr.GetString(dr.GetOrdinal("NumeroDocumento"))
                                        },
                                        Local = new Local
                                        {
                                            Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
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

            return lista;
        }

        public LocalPersonal Buscar(int codigo)
        {
            LocalPersonal contrato = null;
            string sql = $@"SELECT Codigo, CodigoPersonal, CodigoLocal, Cargo, FechaInicio, FechaFin, Sueldo, CorreoEmpresarial, CelularEmpresarial
                      FROM localpersonal 
                      WHERE Codigo = '{codigo}'";

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
                                contrato = new LocalPersonal()
                                {
                                    Codigo = dr.GetInt16(dr.GetOrdinal("Codigo")),
                                    FechaInicio = dr.GetString(dr.GetOrdinal("FechaInicio")),
                                    FechaFin = dr.GetString(dr.GetOrdinal("FechaFin")),
                                    Cargo = dr.GetString(dr.GetOrdinal("Cargo")),
                                    Sueldo = dr.GetFloat(dr.GetOrdinal("Sueldo")),
                                    CorreoEmpresarial = dr.GetString(dr.GetOrdinal("CorreoEmpresarial")),
                                    CelularEmpresarial = dr.GetString(dr.GetOrdinal("CelularEmpresarial")),
                                    Personal = new Personal
                                    {
                                        Codigo = dr.GetInt32(dr.GetOrdinal("CodigoPersonal")),
                                    },
                                    Local = new Local
                                    {
                                        Codigo = dr.GetInt16(dr.GetOrdinal("CodigoLocal")),
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

            return contrato;
        }
        public List<LocalPersonal> ListarVigentes()
        {
            List<LocalPersonal> lista = null;
            string sql = $@"SELECT L.Codigo, O.Nombre, E.RazonSocial, P.ApellidoPaterno, P.ApellidoMaterno, P.Nombres, P.NumeroDocumento,
                L.FechaInicio, L.FechaFin, L.Sueldo, L.Vigencia, L.Cargo, L.CelularEmpresarial, L.CorreoEmpresarial
            	FROM localpersonal L JOIN personal P ON L.CodigoPersonal = P.Codigo JOIN local O ON L.CodigoLocal = O.Codigo
                JOIN empresa E on E.Codigo = O.CodigoEmpresa
            	ORDER BY P.ApellidoPaterno, P.ApellidoMaterno, P.Nombres
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
                            lista = new List<LocalPersonal>();
                            while (dr.Read() == true)
                            {
                                lista.Add(
                                    new LocalPersonal
                                    {
                                        Codigo = dr.GetInt32(dr.GetOrdinal("Codigo")),
                                        FechaInicio = dr.GetString(dr.GetOrdinal("FechaInicio")),
                                        Sueldo = dr.GetFloat(dr.GetOrdinal("Sueldo")),
                                        Cargo = dr.GetString(dr.GetOrdinal("Cargo")),
                                        CelularEmpresarial = dr.GetString(dr.GetOrdinal("CelularEmpresarial")),
                                        CorreoEmpresarial = dr.GetString(dr.GetOrdinal("CorreoEmpresarial")),
                                        Vigencia = dr.GetBoolean(dr.GetOrdinal("Vigencia")),
                                        FechaFin = dr.GetString(dr.GetOrdinal("FechaFin")),
                                        Personal = new Personal
                                        {
                                            Nombre = dr.GetString(dr.GetOrdinal("Nombres")),
                                            ApellidoPaterno = dr.GetString(dr.GetOrdinal("ApellidoPaterno")),
                                            ApellidoMaterno = dr.GetString(dr.GetOrdinal("ApellidoMaterno")),
                                            NumeroDocumento = dr.GetString(dr.GetOrdinal("NumeroDocumento"))
                                        },
                                        Local = new Local
                                        {
                                            Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
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

            return lista;
        }

        public List<LocalPersonal> ListarPorMesVencimiento(string param1, string param2)
        {
            List<LocalPersonal> lista = null;
            string sql = $@"SELECT L.Codigo, O.Nombre, E.RazonSocial, P.ApellidoPaterno, P.ApellidoMaterno, P.Nombres, P.NumeroDocumento,
                L.FechaInicio, L.FechaFin, L.Sueldo, L.Vigencia, L.Cargo, L.CelularEmpresarial, L.CorreoEmpresarial
            	FROM localpersonal L JOIN personal P ON L.CodigoPersonal = P.Codigo JOIN local O ON L.CodigoLocal = O.Codigo
                JOIN empresa E on E.Codigo = O.CodigoEmpresa
                WHERE (L.FechaFin > '{param1}') AND (L.FechaFin < '{param2}')
                ORDER BY P.ApellidoPaterno, P.ApellidoMaterno, P.Nombres";

            //string param1, string param2
            //DateTime param1, DateTime param2
            //ORDER BY P.ApellidoPaterno, P.ApellidoMaterno, P.Nombres
            //AND(L.FechaFin > '{param2}')
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
                            lista = new List<LocalPersonal>();
                            while (dr.Read() == true)
                            {
                                lista.Add(
                                    new LocalPersonal
                                    {
                                        Codigo = dr.GetInt32(dr.GetOrdinal("Codigo")),
                                        FechaInicio = dr.GetString(dr.GetOrdinal("FechaInicio")),
                                        Sueldo = dr.GetFloat(dr.GetOrdinal("Sueldo")),
                                        Cargo = dr.GetString(dr.GetOrdinal("Cargo")),
                                        CelularEmpresarial = dr.GetString(dr.GetOrdinal("CelularEmpresarial")),
                                        CorreoEmpresarial = dr.GetString(dr.GetOrdinal("CorreoEmpresarial")),
                                        Vigencia = dr.GetBoolean(dr.GetOrdinal("Vigencia")),
                                        FechaFin = dr.GetString(dr.GetOrdinal("FechaFin")),
                                        Personal = new Personal
                                        {
                                            Nombre = dr.GetString(dr.GetOrdinal("Nombres")),
                                            ApellidoPaterno = dr.GetString(dr.GetOrdinal("ApellidoPaterno")),
                                            ApellidoMaterno = dr.GetString(dr.GetOrdinal("ApellidoMaterno")),
                                            NumeroDocumento = dr.GetString(dr.GetOrdinal("NumeroDocumento"))
                                        },
                                        Local = new Local
                                        {
                                            Nombre = dr.GetString(dr.GetOrdinal("Nombre")),
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

            return lista;
        }
    }
}
