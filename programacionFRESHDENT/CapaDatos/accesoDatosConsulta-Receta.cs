using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using CapaEntidad;
using System.Data;

namespace CapaDatos
{
     public class accesoDatosConsultaReceta
    {
        SqlConnection cnx;
        Consulta_Receta CR = new  Consulta_Receta();
        Conexion cn = new Conexion();
        SqlConnection cm = null;
        int indicador = 0;
        SqlDataReader dr = null;
        List<Consulta_Receta> listaConsulta_Receta = null;
    }
    public int insertarConsulta_Receta(Consulta_Receta  CR)
    {
       try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("RegRecetaRegConsulta", cnx);
                cm.Parameters.AddWithValue("@b", 1);
                cm.Parameters.AddWithValue("@IdReceta", "");
                cm.Parameters.AddWithValue("@IdConsulta", "");
               
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
        public List<Consulta_Receta> listaConsulta_Receta()
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("RegRecetaRegConsulta", cnx);
                cm.Parameters.AddWithValue("@b", 3);
                cm.Parameters.AddWithValue("@IdReceta", "");
                cm.Parameters.AddWithValue("@IdConsulta", "");
                
                

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
                listaConsulta_Receta = new List<Consulta_Receta>();

                while (dr.Read())
                {
                    Consulta_Receta CR= new Consulta_Receta();
                    CR.IdReceta = Convert.ToInt32(dr["IdReceta"].ToString());
                    CR.IdConsulta = Convert.ToInt32(dr["IdConsulta"].ToString());
                   
                    
                    
                    listaConsulta_Receta.Add(R);
                    
                }
            }
            catch (Exception e)
            {
                e.Message.ToString();
                listaConsulta_Receta= null;
               
            }
            finally
            {
                cm.Connection.Close();
            }
            return  listaConsulta_Receta;
        }
        public int eliminarConsulta_Receta(int IdConsulta)
        {
            try
            {
                SqlConnection cnx = cn.conectar();

                cm = new SqlCommand("RegRecetaRegConsulta", cnx);
                cm.Parameters.AddWithValue("@b", 2);
                cm.Parameters.AddWithValue("@IdReceta", CR.IdReceta);
                cm.Parameters.AddWithValue("@IdConsulta", CR.IdConsulta);
               

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
        public int EditarConsulta_Receta (Consulta_Receta CR)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                cm = new SqlCommand("RegRecetaRegConsulta", cnx);
                cm.Parameters.AddWithValue("@b", 4);
                cm.Parameters.AddWithValue("@IdReceta",  CR.IdReceta);
                cm.Parameters.AddWithValue("@IdConsulta", CR.IdConsulta );
            
                

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
        public List<Consulta_Receta> BuscarConsulta_Receta(String dato)
        {
            try
            {
                SqlConnection cnx = cn.conectar();
                
                 cm = new SqlCommand("RegRecetaRegConsulta", cnx);
                cm.Parameters.AddWithValue("@b", 5);
                cm.Parameters.AddWithValue("@IdReceta", "");
                cm.Parameters.AddWithValue("@IdConsulta", "");
               

                cm.CommandType = CommandType.StoredProcedure;
                cnx.Open();
                dr = cm.ExecuteReader();
               listaConsulta_Receta = new List<Consulta_Receta>();
                while (dr.Read())
                {
                  Consulta_Receta CR= new Consulta_Receta();
                    CR.IdReceta = Convert.ToInt32(dr["IdReceta"].ToString());
                    CR.IdConsulta = Convert.ToInt32(dr["IdConsulta"].ToString());
                   
                   listaConsulta_Receta.Add(CR);
                }

            }
            catch (Exception e)
            {
                e.Message.ToString();
               listaConsulta_Receta = null;
            }
            finally
            {
                cm.Connection.Close();
            }
            return  listaConsulta_Receta;
           }
        }

