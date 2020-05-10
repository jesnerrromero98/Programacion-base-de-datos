using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidad;
using System.Data;

namespace CapaDatos
{
    public class accesoDatosConsulta
    {
        SqlConnection cnx;
       Consulta CO = new  Consulta();
        Conexion cn = new Conexion();
        SqlConnection cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Consulta> listaConsulta = null;
    }
    public int insertarConsulta(Consulta CO)
    {
       try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("RegConsulta", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@IdConsulta", "");
                cm.Parameters.AddWithValue("@TipoConsulta", CO.TipoConsulta);
                cm.Parameters.AddWithValue("@IdCita", "");
                cm.Parameters.AddWithValue("@IdEspecialidad", "");
               
                
                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;

            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            {
                cm.Connection.Close();
            }
            return indicador;
        }
        public List<Consulta> listaConsulta()
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("RegConsulta", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@IdConsulta", "");
                cm.Parameters.AddWithValue("@TipoConsulta", CO.TipoConsulta);
                cm.Parameters.AddWithValue("@IdCita", "");
                cm.Parameters.AddWithValue("@IdEspecialidad", "");
                

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaConsulta = new List<Consulta>();

                while (dr.Read())
                {
                    Consulta CO= new Consulta();
                    CO.IdConsulta = Convert.ToInt32(dr["IdConsulta"].ToString());
                    CO.TipoConsulta = dr["TipoConsulta"].ToString();
                    CO.IdCita = Convert.ToInt32(dr["IdCita"].ToString());
                    CO.IdEspecialidad = Convert.ToInt32(dr["IdEspecialidad"].ToString());
                    
                   listaConsulta.Add(CO);
                    
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
              listaConsulta= null;
               
            }
            finally
            {
                cm.Connection.Close();
            }
            return listaConsulta;
        }
        public int eliminarConsulta(int IdConsulta)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("RegConsulta", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@IdConsulta", CO.IdConsulta);
                cm.Parameters.AddWithValue("@TipoConsulta", "");
                cm.Parameters.AddWithValue("@IdCita", CO.IdCita);
                cm.Parameters.AddWithValue("@IdEspecialidad", CO.IdEspecialidad);

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = - 1;

            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            {
                cm.Connection.Close();
            }
            return indicador;
        }
        public int EditarConsulta (Consulta CO)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("RegConsulta", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@IdConsulta",  CO.IdConsulta);
                cm.Parameters.AddWithValue("@TipoConsulta", "");
                cm.Parameters.AddWithValue("@IdCita", CO.IdCita);
                cm.Parameters.AddWithValue("@IdEspecialidad", CO.IdEspecialidad);
                

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                cm.ExecuteNonQuery();
                indicador = 1;

            }
            catch (Exception e)
            {
                e.Message.ToString();
                indicador = 0;
            }
            finally
            {
                cm.Connection.Close();
            }
            return indicador;
        }
        public List<Consulta> BuscarConsulta(String dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                
                 cm = new SqlCommand("RegConsulta", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@IdConsulta", "");
                cm.Parameters.AddWithValue("@TipoConsulta", CO.TipoConsulta);
                cm.Parameters.AddWithValue("@IdCita", "");
                cm.Parameters.AddWithValue("@IdEspecialidad", "");

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
               listaConsulta = new List<Consulta>();
                while (dr.Read())
                {
                  Consulta CO= new Consulta();
                    CO.IdConsulta = Convert.ToInt32(dr["IdConsulta"].ToString());
                    CO.TipoConsulta = dr["TipoConsulta"].ToString();
                    CO.IdCita = Convert.ToInt32(dr["IdCita"].ToString());
                    CO.IdEspecialidad = Convert.ToInt32(dr["IdEspecialidad"].ToString());
                   listaConsulta.Add(CO);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaConsulta = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return  listaConsulta;
           }
        }
    
